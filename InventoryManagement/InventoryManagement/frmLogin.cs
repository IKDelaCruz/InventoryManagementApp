using InventoryManagement.Model;
using InventoryManagement.Repository;
using InventoryManagement.Utils;
using InventoryManagement.ViewModel;
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
        public object InventoryDatabase { get; private set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DoAuth();

            //Singleton.Instance.RequestModel.SendEmail();
        }


        private void DoAuth()
        {
            var userLDAP = true;

            var result = Singleton.Instance.UserModel.AuthenticateUser(txtUsername.Text.Trim(), txtPassord.Text.Trim(), userLDAP);
            if (result != null)
            {
                //= result;

                //MessageBox.Show("Welcome Back "+ result.Firstname);
                Singleton.Instance.TransactionModel.InsertLog(Singleton.Instance.UserModel.CurrentUser.Id, 0, ViewModel.TransactionType.Login, "");
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
            if (Singleton.Instance.UserModel.CurrentUser == null)
            {
                //Application.Exit();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Select();
        }
    }
}
