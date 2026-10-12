using System;
using System.Windows.Forms;

namespace DBapplication
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login loginForm = new Login();
            Application.Run(loginForm);
        }
    }
}
