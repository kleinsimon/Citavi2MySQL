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
        public IEnumerable<object> ItemList
        {
            get { return _itemlist; }
            set
            {
                _itemlist = value.ToList();
                listBoxAllItems.DataSource = _itemlist;
            }
        }
        public BindingList<object> Selection
        {
            get { return _selection; }
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
            listBoxAllItems.DataSource = _itemlist.Where(item => item.ToString().ToUpper().Contains(textBoxFilter.Text.ToUpper())).ToList();
            setDisplayMember();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            listBoxSelectedItems.ClearSelected();
            foreach (object cat in listBoxAllItems.SelectedItems)
            {
                if (Selection.Contains(cat)) continue;
                Selection.Add(cat);
                listBoxSelectedItems.SelectedItems.Add(cat);
            }
        }

        private void buttonRemoveCategory_Click(object sender, EventArgs e)
        {
            int tmp = listBoxSelectedItems.SelectedIndex;
            Selection.RemoveAll(item => listBoxSelectedItems.SelectedItems.Contains(item));
            listBoxSelectedItems.SelectedIndex = Math.Min(tmp, Selection.Count - 1);
        }

        private void buttonClearCategories_Click(object sender, EventArgs e)
        {
            Selection.Clear();
        }
    }

    public class FilterBoxChangedEventArgs : EventArgs
    {

    }
}
