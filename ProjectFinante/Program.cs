using System;
using System.Windows.Forms;

namespace ProjectFinante
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database.initDatabase();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool checking_db = false;
            if (checking_db)
            {
                Application.Run(new DBManagement());
            }
            else
            {
                Application.Run(new Form1());
            }
           
           
        }
    }
}
