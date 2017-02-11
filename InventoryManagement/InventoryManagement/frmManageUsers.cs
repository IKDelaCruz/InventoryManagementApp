using InventoryManagement.Model;
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
    public partial class frmManageUsers : frmBase
    {
        public frmManageUsers()
        {
            InitializeComponent();

            DisplayUsers();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new frmManageUserInfo().ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DisplayUsers()
        {
            var users = Singleton.Instance.UserModel.GetUsers();
            lvUsers.Items.Clear();

            lvUsers.LoadData(users);

         

        }

        private void lvUsers_DoubleClick(object sender, EventArgs e)
        {
            var selected = lvUsers.SelectedItems[0];
            var id = Convert.ToInt32(selected.SubItems[1].Text);


            var dlg = new frmManageUserInfo(id);
            dlg.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {

        }

        private void lvUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayUsers();
        }
    }
}
