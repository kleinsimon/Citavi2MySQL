namespace ExportToMySQL
{
    partial class FilterBox
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxAll = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxAllItems = new System.Windows.Forms.ListBox();
            this.listBoxSelectedItems = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.buttonRemoveCategory = new System.Windows.Forms.Button();
            this.buttonClearCategories = new System.Windows.Forms.Button();
            this.groupBoxAll.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAll
            // 
            this.groupBoxAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAll.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxAll.Location = new System.Drawing.Point(3, 3);
            this.groupBoxAll.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxAll.Name = "groupBoxAll";
            this.groupBoxAll.Size = new System.Drawing.Size(478, 259);
            this.groupBoxAll.TabIndex = 9;
            this.groupBoxAll.TabStop = false;
            this.groupBoxAll.Text = "Filter";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.checkBoxAll, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFilter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBoxAllItems, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxSelectedItems, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(466, 234);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilter.Location = new System.Drawing.Point(3, 3);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(202, 20);
            this.textBoxFilter.TabIndex = 5;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxCatFilter_TextChanged);
            this.textBoxFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFilter_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Auswahl";
            // 
            // listBoxAllItems
            // 
            this.listBoxAllItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxAllItems.FormattingEnabled = true;
            this.listBoxAllItems.Location = new System.Drawing.Point(3, 29);
            this.listBoxAllItems.Name = "listBoxAllItems";
            this.listBoxAllItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxAllItems.Size = new System.Drawing.Size(202, 199);
            this.listBoxAllItems.TabIndex = 0;
            this.listBoxAllItems.DoubleClick += new System.EventHandler(this.listBoxAllItems_DoubleClick);
            // 
            // listBoxSelectedItems
            // 
            this.listBoxSelectedItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxSelectedItems.FormattingEnabled = true;
            this.listBoxSelectedItems.Location = new System.Drawing.Point(260, 29);
            this.listBoxSelectedItems.Name = "listBoxSelectedItems";
            this.listBoxSelectedItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxSelectedItems.Size = new System.Drawing.Size(203, 199);
            this.listBoxSelectedItems.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.buttonAddCategory);
            this.flowLayoutPanel1.Controls.Add(this.buttonRemoveCategory);
            this.flowLayoutPanel1.Controls.Add(this.buttonClearCategories);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(211, 29);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(43, 202);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.Location = new System.Drawing.Point(211, 3);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(43, 17);
            this.checkBoxAll.TabIndex = 8;
            this.checkBoxAll.Text = "Alle";
            this.checkBoxAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxAll.UseVisualStyleBackColor = true;
            this.checkBoxAll.CheckedChanged += new System.EventHandler(this.checkBoxAll_CheckedChanged);
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(3, 3);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(35, 23);
            this.buttonAddCategory.TabIndex = 3;
            this.buttonAddCategory.Text = "+";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // buttonRemoveCategory
            // 
            this.buttonRemoveCategory.Location = new System.Drawing.Point(3, 32);
            this.buttonRemoveCategory.Name = "buttonRemoveCategory";
            this.buttonRemoveCategory.Size = new System.Drawing.Size(35, 23);
            this.buttonRemoveCategory.TabIndex = 6;
            this.buttonRemoveCategory.Text = "-";
            this.buttonRemoveCategory.UseVisualStyleBackColor = true;
            this.buttonRemoveCategory.Click += new System.EventHandler(this.buttonRemoveCategory_Click);
            // 
            // buttonClearCategories
            // 
            this.buttonClearCategories.Location = new System.Drawing.Point(3, 61);
            this.buttonClearCategories.Name = "buttonClearCategories";
            this.buttonClearCategories.Size = new System.Drawing.Size(35, 23);
            this.buttonClearCategories.TabIndex = 7;
            this.buttonClearCategories.Text = "0";
            this.buttonClearCategories.UseVisualStyleBackColor = true;
            this.buttonClearCategories.Click += new System.EventHandler(this.buttonClearCategories_Click);
            // 
            // FilterBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxAll);
            this.Name = "FilterBox";
            this.Size = new System.Drawing.Size(481, 262);
            this.groupBoxAll.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAll;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Button buttonClearCategories;
        private System.Windows.Forms.ListBox listBoxAllItems;
        private System.Windows.Forms.Button buttonRemoveCategory;
        private System.Windows.Forms.ListBox listBoxSelectedItems;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBoxAll;
    }
}
