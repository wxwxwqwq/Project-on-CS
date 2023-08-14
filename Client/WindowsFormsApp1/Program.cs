using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Registration());            
            Application.Run(new Authorization());
            //Application.Run(new MainMenuForUsers());
            //Application.Run(new MainMenuForAdmins());
            //Application.Run(new ParcelsAdd());
            
        }
    }
}
