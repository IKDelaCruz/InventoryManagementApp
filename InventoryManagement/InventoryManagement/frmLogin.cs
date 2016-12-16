using InventoryManagement.Model;
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
    public partial class frmLogin : frmBase
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DoAuth();
        }
        private void DoAuth()
        {
            
            var result = Singleton.Instance.UserModel.AuthenticateUser(txtUsername.Text.Trim(), txtPassord.Text.Trim());
            if(result != null)
            {
                //Singleton.Instance.UserModel.CurrentUser = result;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid credentials, please try again.", "User Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Singleton.Instance.UserModel.CurrentUser == null)
            {
                Application.Exit();
            }
        }
    }
}
