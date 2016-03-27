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
            SwissAcademic.Controls.CommandbarMenu menu = ParentForm.GetMainCommandbarManager().
                GetReferenceEditorCommandbar(MainFormReferenceEditorCommandbarId.Menu).
                GetCommandbarMenu(MainFormReferenceEditorCommandbarMenuId.Tools);
            menu.AddCommandbarButton("ExportAllTitlesToMysql", "MySQL Export Config");
            menu.AddCommandbarButton("DoExportAllTitlesToMysql", "Export References MySQL");

            base.OnHostingFormLoaded(hostingForm);
        }

        protected override void OnBeforePerformingCommand(SwissAcademic.Controls.BeforePerformingCommandEventArgs e)
        {
            if (e.Key == "ExportAllTitlesToMysql")
            {
                showDialog((MainForm)e.Form);
                e.Handled = true;
            }
            else if (e.Key == "DoExportAllTitlesToMysql")
            {
                showDialog((MainForm)e.Form, true);
                e.Handled = true;
            }

            base.OnBeforePerformingCommand(e);
        }


        void showDialog(MainForm Form, bool silentMode = false)
        {
            ActiveForm = new MysqlExportMain(Form, silentMode);
            if (!silentMode)
                ActiveForm.Show();
        }
    }
}
