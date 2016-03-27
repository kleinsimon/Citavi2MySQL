using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Xml.Linq;
using System.Xml.XPath;

using MySql.Data.MySqlClient;
using SwissAcademic.Citavi;
using SwissAcademic.Citavi.Shell;

namespace ExportToMySQL
{
    public partial class MysqlExportMain : Form
    {
        MainForm CitaviForm;
        DataTable FilteredReferences = new DataTable();
        List<PropertyInfo> ReferenceFields = new List<PropertyInfo>();
        MySqlConnectionStringBuilder sqlconn = new MySqlConnectionStringBuilder();
        Type[] allowed = { typeof(string), typeof(ReferencePersonCollection), typeof(ReferenceLocationCollection), typeof(ReferenceType), typeof(Periodical) };
        bool pauseUpdate = false;
        bool silentMode = false;
        int debugLevel = 1;
        int majorVersion = 0;

        public MysqlExportMain(MainForm Form, bool silentmode = false)
        {
            InitializeComponent();
            SuspendLayout();
            CitaviForm = Form;
            silentMode = silentmode;
            majorVersion = int.Parse(CitaviForm.ProductVersion.Split('.')[0]);

            foreach (PropertyInfo p in typeof(Reference).GetProperties())
            {
                //if (allowed.Contains(p.PropertyType))
                //{
                ReferenceFields.Add(p);
                //}
            }

            initializeTable();

            filterBoxCategories.ItemList = CitaviForm.Project.AllCategories;
            filterBoxCategories.DisplayMember = "FullName";
            filterBoxCategories.OnSelectionChanged += filterBoxCategories_OnSelectionChanged;
#if CITAVI5
            filterBoxGroups.ItemList = CitaviForm.Project.Groups;
            filterBoxGroups.DisplayMember = "FullName";
            filterBoxGroups.OnSelectionChanged += FilterBoxGroups_OnSelectionChanged;
#endif
#if CITAVI4
            filterBoxGroups.Disabled = true;
            //filterBoxGroups.Dispose();
            //tableLayoutPanel1.SetColumn(filterBoxLocation);
#endif
            filterBoxFields.ItemList = ReferenceFields;
            filterBoxFields.DisplayMember = "Name";
            filterBoxFields.OnSelectionChanged += filterBoxFields_OnSelectionChanged;
            filterBoxLocation.ItemList = CitaviForm.Project.Libraries;
            filterBoxLocation.DisplayMember = "FullName";

            loadSettings();

            dataGridViewReferences.AutoGenerateColumns = false;
            dataGridViewReferences.DataSource = FilteredReferences;
            dataGridViewReferences.DoubleBuffered(true);
            updateFields();

            ResumeLayout();
            if (silentMode)
            {
                updateTable();
            }
        }

        void loadSettings()
        {
            pauseUpdate = true;

            if (Properties.Settings.Default.upgradeNeeded)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.upgradeNeeded = false;
            }

            if (Properties.Settings.Default.FilterCats != null)
            {
                foreach (string c in Properties.Settings.Default.FilterCats)
                {
                    Category ci = CitaviForm.Project.AllCategories.FindName(c);
                    if (ci != null)
                        filterBoxCategories.Selection.Add(ci);
                }
            }
#if CITAVI5
            if (Properties.Settings.Default.FilterGroups != null)
            {
                foreach (string c in Properties.Settings.Default.FilterGroups)
                {
                    SwissAcademic.Citavi.Group ci = CitaviForm.Project.Groups.FindFullName(c);
                    if (ci != null)
                        filterBoxGroups.Selection.Add(ci);
                }
            }
            filterBoxGroups.selectAll = Properties.Settings.Default.FilterGroupsAll;
#endif
            if (Properties.Settings.Default.FilterFields != null)
            {
                foreach (string f in Properties.Settings.Default.FilterFields)
                {
                    PropertyInfo fi = ReferenceFields.Find(n => n.Name == f);
                    if (fi != null)
                        filterBoxFields.Selection.Add(fi);
                }
            }

            if (Properties.Settings.Default.FilterLocations != null)
            {
                foreach (string l in Properties.Settings.Default.FilterLocations)
                {
                    Library li = CitaviForm.Project.Libraries.FindFullName(l);
                    if (li != null)
                        filterBoxLocation.Selection.Add(li);
                }
            }

            filterBoxCategories.selectAll = Properties.Settings.Default.FilterCatsAll;
            filterBoxFields.selectAll = Properties.Settings.Default.FilterFieldsAll;
            filterBoxLocation.selectAll = Properties.Settings.Default.FilterLocationsAll;

            pauseUpdate = false;
            getFilteredReferences();
        }

        bool saveSettings()
        {
            System.Collections.Specialized.StringCollection cats = new System.Collections.Specialized.StringCollection();
            foreach (Category c in filterBoxCategories.Selection)
            {
                cats.Add(c.Name);
            }
            Properties.Settings.Default.FilterCats = cats;
#if CITAVI5
            System.Collections.Specialized.StringCollection groups = new System.Collections.Specialized.StringCollection();
            foreach (SwissAcademic.Citavi.Group c in filterBoxGroups.Selection)
            {
                groups.Add(c.Name);
            }
            Properties.Settings.Default.FilterGroups = groups;
            Properties.Settings.Default.FilterGroupsAll = filterBoxGroups.selectAll;
#endif
            System.Collections.Specialized.StringCollection fields = new System.Collections.Specialized.StringCollection();
            foreach (PropertyInfo f in filterBoxFields.Selection)
            {
                fields.Add(f.Name);
            }
            Properties.Settings.Default.FilterFields = fields;

            System.Collections.Specialized.StringCollection locs = new System.Collections.Specialized.StringCollection();
            foreach (Library l in filterBoxLocation.Selection)
            {
                fields.Add(l.Name);
            }
            Properties.Settings.Default.FilterLocations = fields;

            Properties.Settings.Default.FilterCatsAll = filterBoxCategories.selectAll;
            Properties.Settings.Default.FilterFieldsAll = filterBoxFields.selectAll;
            Properties.Settings.Default.FilterLocationsAll = filterBoxLocation.selectAll;

            Properties.Settings.Default.Save();

            return true;
        }

        void debugOutput(string Msg, int level = 0)
        {
            if (level > debugLevel)
                return;
            MessageBox.Show(Msg);
        }

        void initializeTable()
        {
            FilteredReferences.Clear();
            FilteredReferences.Columns.Clear();
            foreach (PropertyInfo p in ReferenceFields)
            {
                FilteredReferences.Columns.Add(p.Name);
            }
            FilteredReferences.Columns.Add("Category");
            FilteredReferences.Columns.Add("Group");
        }

        void filterBoxCategories_OnSelectionChanged(object source, FilterBoxChangedEventArgs e)
        {
            if (!pauseUpdate)
                getFilteredReferences();
        }

        private void FilterBoxGroups_OnSelectionChanged(object source, FilterBoxChangedEventArgs e)
        {
            if (!pauseUpdate)
                getFilteredReferences();
        }

        void filterBoxFields_OnSelectionChanged(object source, FilterBoxChangedEventArgs e)
        {
            if (!pauseUpdate)
                updateFields();
        }

        private void updateFields()
        {
            DataGridView dgv = dataGridViewReferences;
            dgv.Columns.Clear();

            foreach (PropertyInfo p in filterBoxFields.Selection)
            {
                DataGridViewColumn col = new DataGridViewTextBoxColumn();
                col.Name = p.Name;
                col.HeaderText = p.Name;
                col.DataPropertyName = p.Name;
                dgv.Columns.Add(col);
            }
            getFilteredReferences();
        }

        private void getFilteredReferences()
        {
            FilteredReferences.Clear();
            FilteredReferences.BeginLoadData();

            ProjectReferenceCollection refs = CitaviForm.Project.References;
            Category[] filteredCats = filterBoxCategories.Selection.OfType<Category>().ToArray();
#if CITAVI5
            SwissAcademic.Citavi.Group[] filteredGroups = filterBoxGroups.Selection.OfType<SwissAcademic.Citavi.Group>().ToArray();

            var queryRefs =
                from r in refs
                where r.Categories.Intersect(filteredCats).Any() && r.Groups.Intersect(filteredGroups).Any()
                select r;
#endif
#if CITAVI4
            var queryRefs =
                from r in refs
                where r.Categories.Intersect(filteredCats).Any()
                select r;
#endif

            foreach (Reference r in queryRefs)
            {
                DataRow nr = FilteredReferences.Rows.Add();
                List<string> Items = new List<string>();

                foreach (PropertyInfo p in filterBoxFields.Selection)
                {
                    object property = p.GetValue(r);
                    if (p.PropertyType == typeof(string))
                        nr[p.Name] = (string)property;

                    else if (p.PropertyType == typeof(ReferencePersonCollection))
                    {
                        foreach (Person person in (ReferencePersonCollection)property)
                        {
                            if (nr[p.Name] != DBNull.Value)
                                nr[p.Name] += "; ";
                            nr[p.Name] += person.LastName + ", " + Regex.Replace(person.FirstName, @"(\w)\w+[^.]", @"$1."); ;
                        }

                    }

                    else if (p.PropertyType == typeof(ReferenceLocationCollection))
                    {
                        ReferenceLocationCollection ptmp = (ReferenceLocationCollection)property;
                        foreach (Location l in ptmp)
                        {
                            if (filterBoxLocation.Selection.Contains(l.Library))
                            {
                                if (nr[p.Name] != DBNull.Value)
                                    nr[p.Name] += ";";
                                nr[p.Name] += l.FullName;
                            }
                        }
                    }

                    else if (p.PropertyType == typeof(Periodical))
                    {
                        Periodical ptmp = ((Periodical)property);
                        if (ptmp != null)
                            nr[p.Name] = ptmp.Name;
                    }
                    else if (p.PropertyType == typeof(Reference))
                    {
                        Reference ptmp = ((Reference)property);
                        if (ptmp != null)
                            nr[p.Name] = ptmp.Title;
                    }
                    else
                    {
                        PropertyInfo propinf = null;
                        MethodInfo meminf = null;
                        try
                        {
                            propinf = property.GetType().GetProperty("Name");
                        }
                        catch { }
                        try
                        {
                            meminf = property.GetType().GetMethod("ToString");
                        }
                        catch { }
                        if (propinf != null)
                        {
                            nr[p.Name] = (string)propinf.GetValue(property);
                        }
                        else if (meminf != null)
                        {
                            nr[p.Name] = (string)meminf.Invoke(property, null);
                        }
                    }
                }

            }
            FilteredReferences.EndLoadData();
        }

        public bool updateTable(bool noChange = false)
        {
            Process plink = null;

            if (Properties.Settings.Default.SSHtunnel)
            {
                try
                {
                    sqlconn.Server = @"127.0.0.1";
                    sqlconn.Port = uint.Parse(Properties.Settings.Default.SSHPort);

                    ProcessStartInfo psi = new ProcessStartInfo(Properties.Settings.Default.plinkPath);

                    psi.Arguments = "-ssh -l " + Properties.Settings.Default.SSHUser + " -L " + Properties.Settings.Default.port + ":localhost:" +
                                    Properties.Settings.Default.SSHPort + " -pw " + Properties.Settings.Default.SSHPass + " " + Properties.Settings.Default.server;


                    psi.RedirectStandardInput = true;
                    psi.RedirectStandardOutput = true;
                    psi.WindowStyle = ProcessWindowStyle.Hidden;
                    psi.UseShellExecute = false;
                    psi.CreateNoWindow = true;

                    plink = Process.Start(psi);
                }
                catch
                {
                    debugOutput("SSH-Tunnel konnte nicht aufgebaut werden", 0);
                    return false;
                }
            }
            else
            {
                sqlconn.Server = Properties.Settings.Default.server;
                sqlconn.Port = Properties.Settings.Default.port;
            }

            sqlconn.UserID = Properties.Settings.Default.user;
            sqlconn.Password = Properties.Settings.Default.password;
            sqlconn.Database = Properties.Settings.Default.database;

            string table = Properties.Settings.Default.table;
            FilteredReferences.TableName = table;

            using (MySqlConnection connection = new MySqlConnection(sqlconn.ConnectionString))
            {
                try
                {
                    connection.Open();
                    if (!connection.Ping())
                    {
                        debugOutput("No Connection to Server. \r\n Connection: " + sqlconn.ConnectionString);
                        return false;
                    }

                    if (!noChange)
                    {
                        //MySqlCommand del = new MySqlCommand(@"TRUNCATE TABLE " + sqlconn.Database + "." + table, connection);
                        //del.ExecuteNonQuery();
                        if (MessageBox.Show("Tabelle " + table + " in Datenbank " + sqlconn.Database + " wirklich überschreiben?", "Tabelle überschreiben...", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
                            return false;
                        initMysqlTable(connection, table).ExecuteNonQuery();


                        MySqlDataAdapter adapter = new MySqlDataAdapter(@"SELECT * FROM " + sqlconn.Database + "." + table, connection);
                        MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

                        builder.SetAllValues = true;
                        builder.ConflictOption = ConflictOption.OverwriteChanges;
                        adapter.ContinueUpdateOnError = true;

                        adapter.Update(FilteredReferences);
                    }
                    debugOutput("Successful", (noChange) ? 1 : 2);
                }
                catch (Exception ex)
                {
                    debugOutput(ex.Message.ToString(), 0);
                    return false;
                }
            }

            try
            {
                plink.StandardInput.WriteLine("exit");

                plink.Kill();
                plink.Dispose();
            }
            catch { }
            return true;
        }

        private MySqlCommand initMysqlTable(MySqlConnection sqlconn, string table)
        {
            string tabs = "";
            foreach (PropertyInfo p in filterBoxFields.Selection)
            {
                tabs += @"`" + p.Name + "` TEXT,";
            }
            string id = "`" + sqlconn.Database + "`.`" + table + "`";
            string strCreate = @"DROP TABLE IF EXISTS " + id + "; " +
                             "CREATE TABLE IF NOT EXISTS " + id + " (" +
                             "`rowID` int NOT NULL AUTO_INCREMENT, " +
                             tabs +
                             "PRIMARY KEY(rowID));";

            MySqlCommand cmd = new MySqlCommand(strCreate, sqlconn);

            return cmd;
        }

        private void onMysqlSettingsOpenClick(object sender, EventArgs e)
        {
            (new settings(this)).ShowDialog();
        }

        private void onSaveSettingsClick(object sender, EventArgs e)
        {
            if (saveSettings()) debugOutput("Saved", 1);
        }

        private void onSaveToDatabaseClick(object sender, EventArgs e)
        {
            if (FilteredReferences.GetChanges() == null)
            {
                debugOutput("Keine Änderungen vorhanden", 1);
                return;
            }
            if (updateTable()) debugOutput("Daten erfolgreich exportiert", 1);
        }

        private void einstellungenExportierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialogSettings.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            SaveFileDialog saveDialog = (SaveFileDialog)sender;
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
            config.SaveAs(saveDialog.FileName);
        }

        private void einstellungenImportierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialogSettings.ShowDialog();
        }

        private void openFileDialogSettings_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog openDialog = (OpenFileDialog)sender;
            XDocument xmlSettings = XDocument.Load(openDialog.FileName);
            string appSettingsXmlName = Properties.Settings.Default.Context["GroupName"].ToString();
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);

            try
            {
                config.GetSectionGroup("userSettings").
                    Sections[appSettingsXmlName].
                    SectionInformation.
                    SetRawXml(xmlSettings.XPathSelectElements("//" + appSettingsXmlName).Single().ToString());
                Properties.Settings.Default.Reload();
                loadSettings();
            }
            catch (Exception ex)
            {
                debugOutput("Fehler beim Import der Einstellungen: " + ex.Message, 0);
            }
        }
    }

    public static class ExtensionMethods
    {
        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }

        public static bool HasProperty(this Type obj, string propertyName)
        {
            return obj.GetProperty(propertyName) != null;
        }
    }
}
