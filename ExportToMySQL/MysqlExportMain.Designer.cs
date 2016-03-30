namespace ExportToMySQL
{
    partial class MysqlExportMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MysqlExportMain));
            this.dataGridViewReferences = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterSpeichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inDatenbankSpeichenrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mySQLSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenExportierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenImportierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.saveFileDialogSettings = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogSettings = new System.Windows.Forms.OpenFileDialog();
            this.filterBoxCategories = new ExportToMySQL.FilterBox();
            this.filterBoxGroups = new ExportToMySQL.FilterBox();
            this.filterBoxFields = new ExportToMySQL.FilterBox();
            this.filterBoxLocation = new ExportToMySQL.FilterBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReferences)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewReferences
            // 
            resources.ApplyResources(this.dataGridViewReferences, "dataGridViewReferences");
            this.dataGridViewReferences.AllowUserToAddRows = false;
            this.dataGridViewReferences.AllowUserToDeleteRows = false;
            this.dataGridViewReferences.AllowUserToResizeRows = false;
            this.dataGridViewReferences.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewReferences.CausesValidation = false;
            this.dataGridViewReferences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewReferences, 2);
            this.dataGridViewReferences.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewReferences.MultiSelect = false;
            this.dataGridViewReferences.Name = "dataGridViewReferences";
            this.dataGridViewReferences.ReadOnly = true;
            this.dataGridViewReferences.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewReferences.ShowCellErrors = false;
            this.dataGridViewReferences.ShowCellToolTips = false;
            this.dataGridViewReferences.ShowEditingIcon = false;
            this.dataGridViewReferences.ShowRowErrors = false;
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterSpeichernToolStripMenuItem,
            this.inDatenbankSpeichenrToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            // 
            // filterSpeichernToolStripMenuItem
            // 
            resources.ApplyResources(this.filterSpeichernToolStripMenuItem, "filterSpeichernToolStripMenuItem");
            this.filterSpeichernToolStripMenuItem.Name = "filterSpeichernToolStripMenuItem";
            this.filterSpeichernToolStripMenuItem.Click += new System.EventHandler(this.onSaveSettingsClick);
            // 
            // inDatenbankSpeichenrToolStripMenuItem
            // 
            resources.ApplyResources(this.inDatenbankSpeichenrToolStripMenuItem, "inDatenbankSpeichenrToolStripMenuItem");
            this.inDatenbankSpeichenrToolStripMenuItem.Name = "inDatenbankSpeichenrToolStripMenuItem";
            this.inDatenbankSpeichenrToolStripMenuItem.Click += new System.EventHandler(this.onSaveToDatabaseClick);
            // 
            // settingsToolStripMenuItem
            // 
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mySQLSettingsToolStripMenuItem,
            this.einstellungenExportierenToolStripMenuItem,
            this.einstellungenImportierenToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            // 
            // mySQLSettingsToolStripMenuItem
            // 
            resources.ApplyResources(this.mySQLSettingsToolStripMenuItem, "mySQLSettingsToolStripMenuItem");
            this.mySQLSettingsToolStripMenuItem.Name = "mySQLSettingsToolStripMenuItem";
            this.mySQLSettingsToolStripMenuItem.Click += new System.EventHandler(this.onMysqlSettingsOpenClick);
            // 
            // einstellungenExportierenToolStripMenuItem
            // 
            resources.ApplyResources(this.einstellungenExportierenToolStripMenuItem, "einstellungenExportierenToolStripMenuItem");
            this.einstellungenExportierenToolStripMenuItem.Name = "einstellungenExportierenToolStripMenuItem";
            this.einstellungenExportierenToolStripMenuItem.Click += new System.EventHandler(this.einstellungenExportierenToolStripMenuItem_Click);
            // 
            // einstellungenImportierenToolStripMenuItem
            // 
            resources.ApplyResources(this.einstellungenImportierenToolStripMenuItem, "einstellungenImportierenToolStripMenuItem");
            this.einstellungenImportierenToolStripMenuItem.Name = "einstellungenImportierenToolStripMenuItem";
            this.einstellungenImportierenToolStripMenuItem.Click += new System.EventHandler(this.einstellungenImportierenToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewReferences, 1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.filterBoxCategories);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Controls.Add(this.filterBoxGroups);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            resources.ApplyResources(this.tabControl2, "tabControl2");
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            // 
            // tabPage3
            // 
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Controls.Add(this.filterBoxFields);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Controls.Add(this.filterBoxLocation);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // saveFileDialogSettings
            // 
            this.saveFileDialogSettings.DefaultExt = "xml";
            resources.ApplyResources(this.saveFileDialogSettings, "saveFileDialogSettings");
            this.saveFileDialogSettings.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialogSettings
            // 
            this.openFileDialogSettings.DefaultExt = "xml";
            this.openFileDialogSettings.FileName = "settings.xml";
            resources.ApplyResources(this.openFileDialogSettings, "openFileDialogSettings");
            this.openFileDialogSettings.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogSettings_FileOk);
            // 
            // filterBoxCategories
            // 
            resources.ApplyResources(this.filterBoxCategories, "filterBoxCategories");
            this.filterBoxCategories.DisplayMember = null;
            this.filterBoxCategories.HideGroupPanel = true;
            this.filterBoxCategories.ItemList = ((System.Collections.Generic.IEnumerable<object>)(resources.GetObject("filterBoxCategories.ItemList")));
            this.filterBoxCategories.Modifier = ExportToMySQL.FilterBox.Modifiers.And;
            this.filterBoxCategories.Name = "filterBoxCategories";
            this.filterBoxCategories.selectAll = false;
            this.filterBoxCategories.ShowModifier = false;
            this.filterBoxCategories.Title = "Kategorien Filter";
            // 
            // filterBoxGroups
            // 
            resources.ApplyResources(this.filterBoxGroups, "filterBoxGroups");
            this.filterBoxGroups.DisplayMember = null;
            this.filterBoxGroups.HideGroupPanel = true;
            this.filterBoxGroups.ItemList = ((System.Collections.Generic.IEnumerable<object>)(resources.GetObject("filterBoxGroups.ItemList")));
            this.filterBoxGroups.Modifier = ExportToMySQL.FilterBox.Modifiers.And;
            this.filterBoxGroups.Name = "filterBoxGroups";
            this.filterBoxGroups.selectAll = false;
            this.filterBoxGroups.ShowModifier = true;
            this.filterBoxGroups.Title = "Gruppen Filter";
            // 
            // filterBoxFields
            // 
            resources.ApplyResources(this.filterBoxFields, "filterBoxFields");
            this.filterBoxFields.DisplayMember = null;
            this.filterBoxFields.HideGroupPanel = true;
            this.filterBoxFields.ItemList = ((System.Collections.Generic.IEnumerable<object>)(resources.GetObject("filterBoxFields.ItemList")));
            this.filterBoxFields.Modifier = ExportToMySQL.FilterBox.Modifiers.And;
            this.filterBoxFields.Name = "filterBoxFields";
            this.filterBoxFields.selectAll = false;
            this.filterBoxFields.ShowModifier = false;
            this.filterBoxFields.Title = "Exportierte Spalten";
            // 
            // filterBoxLocation
            // 
            resources.ApplyResources(this.filterBoxLocation, "filterBoxLocation");
            this.filterBoxLocation.DisplayMember = null;
            this.filterBoxLocation.HideGroupPanel = true;
            this.filterBoxLocation.ItemList = ((System.Collections.Generic.IEnumerable<object>)(resources.GetObject("filterBoxLocation.ItemList")));
            this.filterBoxLocation.Modifier = ExportToMySQL.FilterBox.Modifiers.And;
            this.filterBoxLocation.Name = "filterBoxLocation";
            this.filterBoxLocation.selectAll = false;
            this.filterBoxLocation.ShowModifier = false;
            this.filterBoxLocation.Title = "Exportierte Standorte";
            // 
            // MysqlExportMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MysqlExportMain";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReferences)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReferences;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mySQLSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterSpeichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inDatenbankSpeichenrToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem einstellungenExportierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenImportierenToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSettings;
        private System.Windows.Forms.OpenFileDialog openFileDialogSettings;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private FilterBox filterBoxCategories;
        private System.Windows.Forms.TabPage tabPage2;
        private FilterBox filterBoxGroups;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private FilterBox filterBoxFields;
        private System.Windows.Forms.TabPage tabPage4;
        private FilterBox filterBoxLocation;
    }
}