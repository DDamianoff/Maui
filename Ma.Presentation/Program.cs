using System;
using System.Windows.Forms;
using Ma.Controllers.Ma.Ui;
using Ma.Ui;

namespace Ma.Presentation
{
    static class Program
    {
        private static readonly GeneralController controller = new GeneralController();

        public static frmMainWindowForm MainFormWindowForm = new frmMainWindowForm();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            controller.CreateDbIfNoExists();

            Application.Run(MainFormWindowForm);
        }
    }
}