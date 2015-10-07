using System;
using System.Windows.Forms;

namespace Bakery.App
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.Run(new FrmMain());
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            ProcessException(e.ExceptionObject);
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            ProcessException(e.Exception);
        }

        private static void ProcessException(object obj)
        {
            MessageBox.Show(Application.OpenForms[0], obj.ToString(), @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}