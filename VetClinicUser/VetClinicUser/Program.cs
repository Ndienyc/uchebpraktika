using System;
using System.Windows.Forms;

namespace VetClinicUser
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Пример ownerId, в реальном приложении он должен быть определен после логина
            int ownerId = 1;

            Application.Run(new UserMainForm(ownerId));
        }
    }
}
