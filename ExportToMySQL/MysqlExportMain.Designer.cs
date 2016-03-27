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
            this.filterBoxFields = new ExportToMySQL.FilterBox();
            this.filterBoxLocation = new ExportToMySQL.FilterBox();
            this.filterBoxCategories = new ExportToMySQL.FilterBox();
            this.filterBoxGroups = new ExportToMySQL.FilterBox();
            this.saveFileDialogSettings = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogSettings = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReferences)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewReferences
            // 
            this.dataGridViewReferences.AllowUserToAddRows = false;
            this.dataGridViewReferences.AllowUserToDeleteRows = false;
            this.dataGridViewReferences.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReferences.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewReferences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewReferences, 4);
            this.dataGridViewReferences.Location = new System.Drawing.Point(4, 270);
            this.dataGridViewReferences.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewReferences.MultiSelect = false;
            this.dataGridViewReferences.Name = "dataGridViewReferences";
            this.dataGridViewReferences.ReadOnly = true;
            this.dataGridViewReferences.ShowEditingIcon = false;
            this.dataGridViewReferences.Size = new System.Drawing.Size(1284, 509);
            this.dataGridViewReferences.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1292, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterSpeichernToolStripMenuItem,
            this.inDatenbankSpeichenrToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.saveToolStripMenuItem.Text = "Datei";
            // 
            // filterSpeichernToolStripMenuItem
            // 
            this.filterSpeichernToolStripMenuItem.Name = "filterSpeichernToolStripMenuItem";
            this.filterSpeichernToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.filterSpeichernToolStripMenuItem.Text = "Filter Speichern";
            this.filterSpeichernToolStripMenuItem.Click += new System.EventHandler(this.onSaveSettingsClick);
            // 
            // inDatenbankSpeichenrToolStripMenuItem
            // 
            this.inDatenbankSpeichenrToolStripMenuItem.Name = "inDatenbankSpeichenrToolStripMenuItem";
            this.inDatenbankSpeichenrToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.inDatenbankSpeichenrToolStripMenuItem.Text = "In Datenbank speichern";
            this.inDatenbankSpeichenrToolStripMenuItem.Click += new System.EventHandler(this.onSaveToDatabaseClick);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mySQLSettingsToolStripMenuItem,
            this.einstellungenExportierenToolStripMenuItem,
            this.einstellungenImportierenToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.settingsToolStripMenuItem.Text = "Einstellungen";
            // 
            // mySQLSettingsToolStripMenuItem
            // 
            this.mySQLSettingsToolStripMenuItem.Name = "mySQLSettingsToolStripMenuItem";
            this.mySQLSettingsToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.mySQLSettingsToolStripMenuItem.Text = "MySQL Einstellungen";
            this.mySQLSettingsToolStripMenuItem.Click += new System.EventHandler(this.onMysqlSettingsOpenClick);
            // 
            // einstellungenExportierenToolStripMenuItem
            // 
            this.einstellungenExportierenToolStripMenuItem.Name = "einstellungenExportierenToolStripMenuItem";
            this.einstellungenExportierenToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.einstellungenExportierenToolStripMenuItem.Text = "Einstellungen Exportieren";
            this.einstellungenExportierenToolStripMenuItem.Click += new System.EventHandler(this.einstellungenExportierenToolStripMenuItem_Click);
            // 
            // einstellungenImportierenToolStripMenuItem
            // 
            this.einstellungenImportierenToolStripMenuItem.Name = "einstellungenImportierenToolStripMenuItem";
            this.einstellungenImportierenToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.einstellungenImportierenToolStripMenuItem.Text = "Einstellungen Importieren";
            this.einstellungenImportierenToolStripMenuItem.Click += new System.EventHandler(this.einstellungenImportierenToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewReferences, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.filterBoxFields, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.filterBoxLocation, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.filterBoxCategories, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.filterBoxGroups, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1292, 783);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // filterBoxFields
            // 
            this.filterBoxFields.DisplayMember = "";
            this.filterBoxFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterBoxFields.ItemList = ((System.Collections.Generic.IEnumerable<object>)(resources.GetObject("filterBoxFields.ItemList")));
            this.filterBoxFields.Location = new System.Drawing.Point(974, 5);
            this.filterBoxFields.Margin = new System.Windows.Forms.Padding(5);
            this.filterBoxFields.Name = "filterBoxFields";
            this.filterBoxFields.selectAll = false;
            this.filterBoxFields.Size = new System.Drawing.Size(313, 256);
            this.filterBoxFields.TabIndex = 12;
            this.filterBoxFields.Title = "Exportierte Spalten";
            // 
            // filterBoxLocation
            // 
            this.filterBoxLocation.DisplayMember = null;
            this.filterBoxLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterBoxLocation.ItemList = ((System.Collections.Generic.IEnumerable<object>)(resources.GetObject("filterBoxLocation.ItemList")));
            this.filterBoxLocation.Location = new System.Drawing.Point(651, 5);
            this.filterBoxLocation.Margin = new System.Windows.Forms.Padding(5);
            this.filterBoxLocation.Name = "filterBoxLocation";
            this.filterBoxLocation.selectAll = false;
            this.filterBoxLocation.Size = new System.Drawing.Size(313, 256);
            this.filterBoxLocation.TabIndex = 14;
            this.filterBoxLocation.Title = "Exportierte Standorte";
            // 
            // filterBoxCategories
            // 
            this.filterBoxCategories.DisplayMember = "";
            this.filterBoxCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterBoxCategories.ItemList = ((System.Collections.Generic.IEnumerable<object>)(resources.GetObject("filterBoxCategories.ItemList")));
            this.filterBoxCategories.Location = new System.Drawing.Point(5, 5);
            this.filterBoxCategories.Margin = new System.Windows.Forms.Padding(5);
            this.filterBoxCategories.Name = "filterBoxCategories";
            this.filterBoxCategories.selectAll = false;
            this.filterBoxCategories.Size = new System.Drawing.Size(313, 256);
            this.filterBoxCategories.TabIndex = 11;
            this.filterBoxCategories.Title = "Kategorien Filter";
            // 
            // filterBoxGroups
            // 
            this.filterBoxGroups.DisplayMember = null;
            this.filterBoxGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterBoxGroups.ItemList = ((System.Collections.Generic.IEnumerable<object>)(resources.GetObject("filterBoxGroups.ItemList")));
            this.filterBoxGroups.Location = new System.Drawing.Point(327, 4);
            this.filterBoxGroups.Margin = new System.Windows.Forms.Padding(4);
            this.filterBoxGroups.Name = "filterBoxGroups";
            this.filterBoxGroups.selectAll = false;
            this.filterBoxGroups.Size = new System.Drawing.Size(315, 258);
            this.filterBoxGroups.TabIndex = 15;
            this.filterBoxGroups.Title = "Gruppen Filter";
            // 
            // saveFileDialogSettings
            // 
            this.saveFileDialogSettings.DefaultExt = "xml";
            this.saveFileDialogSettings.Filter = "XML-Dateien|*.xml";
            this.saveFileDialogSettings.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialogSettings
            // 
            this.openFileDialogSettings.DefaultExt = "xml";
            this.openFileDialogSettings.FileName = "settings.xml";
            this.openFileDialogSettings.Filter = "XML-Dateien|*.xml";
            this.openFileDialogSettings.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogSettings_FileOk);
            // 
            // MysqlExportMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 811);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MysqlExportMain";
            this.Text = "MysqlExportMain";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReferences)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReferences;
        private FilterBox filterBoxCategories;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mySQLSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterSpeichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inDatenbankSpeichenrToolStripMenuItem;
        private FilterBox filterBoxLocation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem einstellungenExportierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenImportierenToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSettings;
        private System.Windows.Forms.OpenFileDialog openFileDialogSettings;
        private FilterBox filterBoxFields;
        private FilterBox filterBoxGroups;
    }
}