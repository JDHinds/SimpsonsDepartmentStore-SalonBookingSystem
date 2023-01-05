using System;
using System.Windows.Forms;

namespace SimpsonsDepartmentStoreSystem
{
    static class Program
    {
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            objects.Database db = new objects.Database(); //Only run the system if you can connect to the database
            if (db.connect())
            { Application.Run(new gui.BaseMenu()); }
            else
            { MessageBox.Show("Database Connection Unsuccessful.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Application.Exit(); }
        }
    }
}