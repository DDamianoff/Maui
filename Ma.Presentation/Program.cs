using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ma.Controllers.Ma.Ui;

namespace Ma.Presentation
{
    static class Program
    {
        private static GeneralController _controller = new GeneralController();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());



            await _controller.CreateDbIfNoExistsAsync();
        }
    }
}
