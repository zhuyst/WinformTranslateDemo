using System;
using System.Windows.Forms;
using WindowsFormsControlLibrary;

namespace WinformTranslateDemo
{
    static class Program
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //高DPI支持
            if (Environment.OSVersion.Version.Major >= 6) { SetProcessDPIAware(); }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

//            var loginForm = new LoginForm("root","123456", () =>
//            {
//                new MainForm().Show();
//            });
            Application.Run(new MainForm());
        }
    }
}
