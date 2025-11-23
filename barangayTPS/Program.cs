using System;
using System.Windows.Forms;

namespace barangayTPS
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DBHelper.InitializeDatabase(); // This will call CheckAllAccounts

            Application.Run(new FormUserLogin());
        }
    }
}