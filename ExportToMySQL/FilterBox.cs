using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExportToMySQL
{
    public partial class FilterBox : UserControl
    {
        private List<object> _itemlist = new List<object>();
        private BindingList<object> _selection = new BindingList<object>();
        private string _displaymember;
        public bool selectAll
        {
            get { return checkBoxAll.Checked; }
            set
            {
                checkBoxAll.Checked = value;
                toggleControls(!value);
                if (OnSelectionChanged != null)
                    OnSelectionChanged(this, new FilterBoxChangedEventArgs());
            }
        }
        public IEnumerable<object> ItemList
        {
            get { return _itemlist; }
            set
            {
                _itemlist = value.ToList();
                listBoxAllItems.DataSource = _itemlist;
            }
        }
        public List<object> Selection
        {
            get
            {
                if (!selectAll)
                    if (_selection != null)
                        return _selection.ToList<object>();
                    else
                        return null;
                else
                    return _itemlist;
            }
        }
        public string Title
        {
            get { return groupBoxAll.Text; }
            set { groupBoxAll.Text = value; }
        }
        public string DisplayMember
        {
            get
            {
                return _displaymember;
            }
            set
            {
                _displaymember = value;
                setDisplayMember();
            }
        }
        public delegate void FilterBoxChangedEventHandler(object source, FilterBoxChangedEventArgs e);
        public event FilterBoxChangedEventHandler OnSelectionChanged;

        public FilterBox()
        {
            InitializeComponent();
            listBoxSelectedItems.DataSource = _selection;
            listBoxSelectedItems.DisplayMember = "Name";
            _selection.ListChanged += _selection_ListChanged;
        }

        void setDisplayMember()
        {
            listBoxAllItems.DisplayMember = _displaymember;
            listBoxSelectedItems.DisplayMember = _displaymember;
        }

        void _selection_ListChanged(object sender, ListChangedEventArgs e)
        {
            listBoxSelectedItems.DisplayMember = listBoxAllItems.DisplayMember;
            if (OnSelectionChanged != null)
            {
                OnSelectionChanged(this, new FilterBoxChangedEventArgs());
            }
        }

        private void textBoxCatFilter_TextChanged(object sender, EventArgs e)
        {
            string filter = textBoxFilter.Text.ToUpper();

            if (filter == string.Empty || filter.Length < 2)
            {
                listBoxAllItems.DataSource = _itemlist;
                return;
            }

            var query = from item in _itemlist
                        let itemText=item.ToString().ToUpper()
                        where itemText.Contains(filter)
                        orderby Levenshtein.CalculateDistance(itemText, filter)
                        select item;

            listBoxAllItems.DataSource = query.ToList();
            setDisplayMember();

            if (listBoxAllItems.Items.Count > 0)
                listBoxAllItems.SelectedIndex = 0;

        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            AddSelectedCategories();
        }

        private void AddSelectedCategories()
        {
            listBoxSelectedItems.ClearSelected();
            foreach (object cat in listBoxAllItems.SelectedItems)
            {
                if (_selection.Contains(cat)) continue;
                _selection.Add(cat);
                listBoxSelectedItems.SelectedItems.Add(cat);
            }
        }

        private void buttonRemoveCategory_Click(object sender, EventArgs e)
        {
            int tmp = listBoxSelectedItems.SelectedIndex;
            _selection.RemoveAll(item => listBoxSelectedItems.SelectedItems.Contains(item));
            listBoxSelectedItems.SelectedIndex = Math.Min(tmp, _selection.Count - 1);
        }

        private void buttonClearCategories_Click(object sender, EventArgs e)
        {
            _selection.Clear();
        }


        private void textBoxFilter_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (e.KeyCode == Keys.Return)
            {
                AddSelectedCategories();
                e.Handled = true;
            }
            e.Handled = false;
        }

        private void listBoxAllItems_DoubleClick(object sender, EventArgs e)
        {
            AddSelectedCategories();
        }

        private void toggleControls(bool Enabled)
        {
            listBoxAllItems.Enabled = Enabled;
            listBoxSelectedItems.Enabled = Enabled;
            textBoxFilter.Enabled = Enabled;
            buttonAddCategory.Enabled = Enabled;
            buttonClearCategories.Enabled = Enabled;
            buttonRemoveCategory.Enabled = Enabled;
        }

        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            selectAll = checkBoxAll.Checked;
        }
    }

    public class FilterBoxChangedEventArgs : EventArgs
    {

    }

    public static class Levenshtein
    {
        public static int CalculateDistance(string source, string target)
        {
            if (String.IsNullOrEmpty(source))
            {
                if (String.IsNullOrEmpty(target)) return 0;
                return target.Length;
            }
            if (String.IsNullOrEmpty(target)) return source.Length;

            if (source.Length > target.Length)
            {
                var temp = target;
                target = source;
                source = temp;
            }

            var m = target.Length;
            var n = source.Length;
            var distance = new int[2, m + 1];
            // Initialize the distance 'matrix'
            for (var j = 1; j <= m; j++) distance[0, j] = j;

            var currentRow = 0;
            for (var i = 1; i <= n; ++i)
            {
                currentRow = i & 1;
                distance[currentRow, 0] = i;
                var previousRow = currentRow ^ 1;
                for (var j = 1; j <= m; j++)
                {
                    var cost = (target[j - 1] == source[i - 1] ? 0 : 1);
                    distance[currentRow, j] = Math.Min(Math.Min(
                                distance[previousRow, j] + 1,
                                distance[currentRow, j - 1] + 1),
                                distance[previousRow, j - 1] + cost);
                }
            }
            return distance[currentRow, m];
        }
    }
}
