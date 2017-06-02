using InventoryManagement.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class frmSyncLDAPUsers : Form
    {
        public frmSyncLDAPUsers()
        {
            InitializeComponent();
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            SplashForm.ShowSplashScreen();

            LDAPUserImporter li = new LDAPUserImporter();
            li.ImportLDAPUser();

            SplashForm.CloseForm();

            MessageBox.Show("Users Synced Successfully!");
        }
    }
}
