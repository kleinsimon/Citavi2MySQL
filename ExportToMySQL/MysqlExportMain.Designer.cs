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
            this.dataGridViewReferences.AllowUserToAddRows = false;
            this.dataGridViewReferences.AllowUserToDeleteRows = false;
            this.dataGridViewReferences.AllowUserToResizeRows = false;
            this.dataGridViewReferences.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewReferences.CausesValidation = false;
            this.dataGridViewReferences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewReferences, 2);
            this.dataGridViewReferences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReferences.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewReferences.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewReferences.Location = new System.Drawing.Point(4, 304);
            this.dataGridViewReferences.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewReferences.MultiSelect = false;
            this.dataGridViewReferences.Name = "dataGridViewReferences";
            this.dataGridViewReferences.ReadOnly = true;
            this.dataGridViewReferences.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewReferences.ShowCellErrors = false;
            this.dataGridViewReferences.ShowCellToolTips = false;
            this.dataGridViewReferences.ShowEditingIcon = false;
            this.dataGridViewReferences.ShowRowErrors = false;
            this.dataGridViewReferences.Size = new System.Drawing.Size(1264, 539);
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
            this.menuStrip1.Size = new System.Drawing.Size(1272, 28);
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
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewReferences, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1272, 847);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(630, 294);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.filterBoxCategories);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(622, 265);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kategorien Filter";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.filterBoxGroups);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(622, 265);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gruppen Filter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(639, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(630, 294);
            this.tabControl2.TabIndex = 17;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.filterBoxFields);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(622, 265);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Exportierte Spalten";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.filterBoxLocation);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(339, 265);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Exportierte Standorte";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            // filterBoxCategories
            // 
            this.filterBoxCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterBoxCategories.DisplayMember = null;
            this.filterBoxCategories.HideGroupPanel = false;
            this.filterBoxCategories.ItemList = ((System.Collections.Generic.IEnumerable<object>)(resources.GetObject("filterBoxCategories.ItemList")));
            this.filterBoxCategories.Location = new System.Drawing.Point(3, 3);
            this.filterBoxCategories.Margin = new System.Windows.Forms.Padding(0);
            this.filterBoxCategories.Modifier = ExportToMySQL.FilterBox.Modifiers.Und;
            this.filterBoxCategories.Name = "filterBoxCategories";
            this.filterBoxCategories.selectAll = false;
            this.filterBoxCategories.ShowModifier = false;
            this.filterBoxCategories.Size = new System.Drawing.Size(616, 259);
            this.filterBoxCategories.TabIndex = 12;
            this.filterBoxCategories.Title = "Kategorien Filter";
            // 
            // filterBoxGroups
            // 
            this.filterBoxGroups.DisplayMember = null;
            this.filterBoxGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterBoxGroups.HideGroupPanel = true;
            this.filterBoxGroups.ItemList = ((System.Collections.Generic.IEnumerable<object>)(resources.GetObject("filterBoxGroups.ItemList")));
            this.filterBoxGroups.Location = new System.Drawing.Point(3, 3);
            this.filterBoxGroups.Margin = new System.Windows.Forms.Padding(4);
            this.filterBoxGroups.Modifier = ExportToMySQL.FilterBox.Modifiers.Und;
            this.filterBoxGroups.Name = "filterBoxGroups";
            this.filterBoxGroups.selectAll = false;
            this.filterBoxGroups.ShowModifier = true;
            this.filterBoxGroups.Size = new System.Drawing.Size(616, 259);
            this.filterBoxGroups.TabIndex = 16;
            this.filterBoxGroups.Title = "Gruppen Filter";
            // 
            // filterBoxFields
            // 
            this.filterBoxFields.DisplayMember = null;
            this.filterBoxFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterBoxFields.HideGroupPanel = true;
            this.filterBoxFields.ItemList = ((System.Collections.Generic.IEnumerable<object>)(resources.GetObject("filterBoxFields.ItemList")));
            this.filterBoxFields.Location = new System.Drawing.Point(3, 3);
            this.filterBoxFields.Margin = new System.Windows.Forms.Padding(5);
            this.filterBoxFields.Modifier = ExportToMySQL.FilterBox.Modifiers.Und;
            this.filterBoxFields.Name = "filterBoxFields";
            this.filterBoxFields.selectAll = false;
            this.filterBoxFields.ShowModifier = false;
            this.filterBoxFields.Size = new System.Drawing.Size(616, 259);
            this.filterBoxFields.TabIndex = 13;
            this.filterBoxFields.Title = "Exportierte Spalten";
            // 
            // filterBoxLocation
            // 
            this.filterBoxLocation.DisplayMember = null;
            this.filterBoxLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterBoxLocation.HideGroupPanel = true;
            this.filterBoxLocation.ItemList = ((System.Collections.Generic.IEnumerable<object>)(resources.GetObject("filterBoxLocation.ItemList")));
            this.filterBoxLocation.Location = new System.Drawing.Point(3, 3);
            this.filterBoxLocation.Margin = new System.Windows.Forms.Padding(5);
            this.filterBoxLocation.Modifier = ExportToMySQL.FilterBox.Modifiers.Und;
            this.filterBoxLocation.Name = "filterBoxLocation";
            this.filterBoxLocation.selectAll = false;
            this.filterBoxLocation.ShowModifier = false;
            this.filterBoxLocation.Size = new System.Drawing.Size(333, 259);
            this.filterBoxLocation.TabIndex = 15;
            this.filterBoxLocation.Title = "Exportierte Standorte";
            // 
            // MysqlExportMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 875);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MysqlExportMain";
            this.Text = "Export 2 MySQL";
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