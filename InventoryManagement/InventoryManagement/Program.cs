﻿using InventoryManagement.Manage;
using InventoryManagement.Utils;
using System;
using System.Windows.Forms;

namespace InventoryManagement
{
    static class Program
    {
        public static ImageList imlType;
        public static ImageList imlSubType;

      

        /// <summary>
        /// 
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //new LDAPUserImporter().ImportLDAPUser();
            //Singleton.Instance.UserModel.CheckDefaultUser();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //SplashForm.ShowSplashScreen();

            frmLauncher mainForm = new frmLauncher(); //this takes ages

            //SplashForm.CloseForm();

            Application.Run(mainForm);

            //Application.Run();
            //Application.Run(new frmMain());
        }
    }
}
