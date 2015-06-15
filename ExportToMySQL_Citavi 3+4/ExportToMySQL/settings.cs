using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExportToMySQL
{
    public partial class settings : Form
    {
        private bool _enableSSH = false;
        MysqlExportMain parentForm;

        public bool enableSSH
        {
            get
            {
                return _enableSSH;
            }
            set
            {
                _enableSSH = value;
                textBoxSSHLocalPort.Enabled = value;
                textBoxSSHPass.Enabled = value;
                textBoxSSHUser.Enabled = value;
                checkBoxSSH.Checked = value;
            }
        }

        public settings(MysqlExportMain P)
        {
            InitializeComponent();

            textBoxServer.Text = Properties.Settings.Default.server;
            textBoxPort.Text = Properties.Settings.Default.port.ToString();
            textBoxDB.Text = Properties.Settings.Default.database;
            textBoxTable.Text = Properties.Settings.Default.table;
            textBoxUser.Text = Properties.Settings.Default.user;
            textBoxPassw.Text = Properties.Settings.Default.password;
            enableSSH = Properties.Settings.Default.SSHtunnel;
            textBoxSSHLocalPort.Text = Properties.Settings.Default.SSHPort;
            textBoxSSHPass.Text = Properties.Settings.Default.SSHPass;
            textBoxSSHUser.Text = Properties.Settings.Default.SSHUser;

            if (File.Exists(Properties.Settings.Default.plinkPath))
            {
                checkBoxPlink.Checked = true;
            }
            parentForm = P;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
            //this.Close();
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.server = textBoxServer.Text;
            uint tmp;
            if (uint.TryParse(textBoxPort.Text, out tmp))
                Properties.Settings.Default.port = tmp;
            Properties.Settings.Default.database = textBoxDB.Text;
            Properties.Settings.Default.user = textBoxUser.Text;
            Properties.Settings.Default.password = textBoxPassw.Text;
            Properties.Settings.Default.table = textBoxTable.Text;
            Properties.Settings.Default.SSHtunnel = enableSSH;
            Properties.Settings.Default.SSHPort = textBoxSSHLocalPort.Text;
            Properties.Settings.Default.SSHPass = textBoxSSHPass.Text;
            Properties.Settings.Default.SSHUser = textBoxSSHUser.Text;

            Properties.Settings.Default.Save();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            enableSSH = !enableSSH;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = Properties.Settings.Default.plinkPath;
            openFileDialog1.ShowDialog();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (File.Exists(openFileDialog1.FileName))
            {
                e.Cancel = false;
                Properties.Settings.Default.plinkPath = openFileDialog1.FileName;
                checkBoxPlink.Checked = true;
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            SaveSettings();
            parentForm.updateTable(true);
        }
    }
}
