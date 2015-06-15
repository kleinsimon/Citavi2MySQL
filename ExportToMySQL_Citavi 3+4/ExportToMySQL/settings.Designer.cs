namespace ExportToMySQL
{
    partial class settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPassw = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTable = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxPlink = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSSHPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSSHUser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSSHLocalPort = new System.Windows.Forms.TextBox();
            this.checkBoxSSH = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonTest = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Adress";
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(90, 12);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(100, 20);
            this.textBoxServer.TabIndex = 1;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(90, 38);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxPort.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server Port";
            // 
            // textBoxDB
            // 
            this.textBoxDB.Location = new System.Drawing.Point(90, 84);
            this.textBoxDB.Name = "textBoxDB";
            this.textBoxDB.Size = new System.Drawing.Size(100, 20);
            this.textBoxDB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "User";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(90, 135);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(100, 20);
            this.textBoxUser.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // textBoxPassw
            // 
            this.textBoxPassw.Location = new System.Drawing.Point(90, 161);
            this.textBoxPassw.Name = "textBoxPassw";
            this.textBoxPassw.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassw.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Database";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(294, 167);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Table";
            // 
            // textBoxTable
            // 
            this.textBoxTable.Location = new System.Drawing.Point(90, 110);
            this.textBoxTable.Name = "textBoxTable";
            this.textBoxTable.Size = new System.Drawing.Size(100, 20);
            this.textBoxTable.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBoxPlink);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxSSHPass);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxSSHUser);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxSSHLocalPort);
            this.groupBox1.Controls.Add(this.checkBoxSSH);
            this.groupBox1.Location = new System.Drawing.Point(196, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 149);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SSH-Tunnel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxPlink
            // 
            this.checkBoxPlink.AutoCheck = false;
            this.checkBoxPlink.AutoSize = true;
            this.checkBoxPlink.Location = new System.Drawing.Point(66, 125);
            this.checkBoxPlink.Name = "checkBoxPlink";
            this.checkBoxPlink.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPlink.TabIndex = 17;
            this.checkBoxPlink.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "plink.exe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "SSH Pass";
            // 
            // textBoxSSHPass
            // 
            this.textBoxSSHPass.Location = new System.Drawing.Point(67, 99);
            this.textBoxSSHPass.Name = "textBoxSSHPass";
            this.textBoxSSHPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxSSHPass.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "SSH User";
            // 
            // textBoxSSHUser
            // 
            this.textBoxSSHUser.Location = new System.Drawing.Point(67, 73);
            this.textBoxSSHUser.Name = "textBoxSSHUser";
            this.textBoxSSHUser.Size = new System.Drawing.Size(100, 20);
            this.textBoxSSHUser.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Local Port";
            // 
            // textBoxSSHLocalPort
            // 
            this.textBoxSSHLocalPort.Location = new System.Drawing.Point(66, 47);
            this.textBoxSSHLocalPort.Name = "textBoxSSHLocalPort";
            this.textBoxSSHLocalPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxSSHLocalPort.TabIndex = 8;
            // 
            // checkBoxSSH
            // 
            this.checkBoxSSH.AutoSize = true;
            this.checkBoxSSH.Location = new System.Drawing.Point(7, 19);
            this.checkBoxSSH.Name = "checkBoxSSH";
            this.checkBoxSSH.Size = new System.Drawing.Size(120, 17);
            this.checkBoxSSH.TabIndex = 7;
            this.checkBoxSSH.Text = "Enable SSH-Tunnel";
            this.checkBoxSSH.UseVisualStyleBackColor = true;
            this.checkBoxSSH.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(196, 167);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(93, 23);
            this.buttonTest.TabIndex = 14;
            this.buttonTest.Text = "Test Connection";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // settings
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 198);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTable);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxPassw);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxServer);
            this.Controls.Add(this.label1);
            this.Name = "settings";
            this.Text = "settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPassw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSSHPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSSHUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSSHLocalPort;
        private System.Windows.Forms.CheckBox checkBoxSSH;
        private System.Windows.Forms.CheckBox checkBoxPlink;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonTest;
    }
}