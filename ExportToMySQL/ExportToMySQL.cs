using System;
using System.Collections.Generic;
using System.Text;

using SwissAcademic.Citavi;
using SwissAcademic.Citavi.Shell;

namespace ExportToMySQL
{
    public class ExportToMySQLMain : CitaviAddOn
    {
        MysqlExportMain ActiveForm;

        public override AddOnHostingForm HostingForm
        {
            get { return AddOnHostingForm.MainForm; }
        }

        protected override void OnHostingFormLoaded(System.Windows.Forms.Form hostingForm)
        {
            MainForm ParentForm = (MainForm)hostingForm;
            ParentForm.GetMainCommandbarManager().
                GetReferenceEditorCommandbar(MainFormReferenceEditorCommandbarId.Menu).
                GetCommandbarMenu(MainFormReferenceEditorCommandbarMenuId.Tools).
                AddCommandbarButton("ExportAllTitlesToMysql", "Export To MySQL");

            base.OnHostingFormLoaded(hostingForm);
        }

        protected override void OnBeforePerformingCommand(SwissAcademic.Controls.BeforePerformingCommandEventArgs e)
        {
            if (e.Key == "ExportAllTitlesToMysql")
            {
                showDialog((MainForm) e.Form);
                e.Handled = true;
            }

            base.OnBeforePerformingCommand(e);
        }

        void showDialog(MainForm Form)
        {
            ActiveForm = new MysqlExportMain(Form);
            ActiveForm.Show();
        }
    }
}
