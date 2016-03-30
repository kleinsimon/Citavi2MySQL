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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterBox));
            this.groupBoxAll = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.listBoxAllItems = new System.Windows.Forms.ListBox();
            this.listBoxSelectedItems = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.buttonRemoveCategory = new System.Windows.Forms.Button();
            this.buttonClearCategories = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxAll.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAll
            // 
            resources.ApplyResources(this.groupBoxAll, "groupBoxAll");
            this.groupBoxAll.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxAll.Name = "groupBoxAll";
            this.groupBoxAll.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.checkBoxAll, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFilter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBoxAllItems, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxSelectedItems, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // checkBoxAll
            // 
            resources.ApplyResources(this.checkBoxAll, "checkBoxAll");
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.UseVisualStyleBackColor = true;
            this.checkBoxAll.CheckedChanged += new System.EventHandler(this.checkBoxAll_CheckedChanged);
            // 
            // textBoxFilter
            // 
            resources.ApplyResources(this.textBoxFilter, "textBoxFilter");
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxCatFilter_TextChanged);
            this.textBoxFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFilter_KeyDown);
            // 
            // listBoxAllItems
            // 
            resources.ApplyResources(this.listBoxAllItems, "listBoxAllItems");
            this.listBoxAllItems.FormattingEnabled = true;
            this.listBoxAllItems.Name = "listBoxAllItems";
            this.listBoxAllItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxAllItems.DoubleClick += new System.EventHandler(this.listBoxAllItems_DoubleClick);
            // 
            // listBoxSelectedItems
            // 
            resources.ApplyResources(this.listBoxSelectedItems, "listBoxSelectedItems");
            this.listBoxSelectedItems.FormattingEnabled = true;
            this.listBoxSelectedItems.Name = "listBoxSelectedItems";
            this.listBoxSelectedItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.buttonAddCategory);
            this.flowLayoutPanel1.Controls.Add(this.buttonRemoveCategory);
            this.flowLayoutPanel1.Controls.Add(this.buttonClearCategories);
            this.flowLayoutPanel1.Controls.Add(this.buttonMod);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // buttonAddCategory
            // 
            resources.ApplyResources(this.buttonAddCategory, "buttonAddCategory");
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // buttonRemoveCategory
            // 
            resources.ApplyResources(this.buttonRemoveCategory, "buttonRemoveCategory");
            this.buttonRemoveCategory.Name = "buttonRemoveCategory";
            this.buttonRemoveCategory.UseVisualStyleBackColor = true;
            this.buttonRemoveCategory.Click += new System.EventHandler(this.buttonRemoveCategory_Click);
            // 
            // buttonClearCategories
            // 
            resources.ApplyResources(this.buttonClearCategories, "buttonClearCategories");
            this.buttonClearCategories.Name = "buttonClearCategories";
            this.buttonClearCategories.UseVisualStyleBackColor = true;
            this.buttonClearCategories.Click += new System.EventHandler(this.buttonClearCategories_Click);
            // 
            // buttonMod
            // 
            resources.ApplyResources(this.buttonMod, "buttonMod");
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // FilterBox
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxAll);
            this.Name = "FilterBox";
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
        private System.Windows.Forms.Button buttonMod;
    }
}
