using AuthenticationLibrary;
using InventoryManagement.Model;
using InventoryManagement.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //new LDAPUserImporter().ImportLDAPUser();
            //Singleton.Instance.UserModel.CheckDefaultUser();
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            

            Application.Run(new frmLauncher());
        }
    }
}
