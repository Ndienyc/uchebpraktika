using System;
using System.Windows.Forms;

namespace VetClinicApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!DatabaseHelper.CheckDatabase())
                return;

            Application.Run(new MainForm());
        }
    }
}
