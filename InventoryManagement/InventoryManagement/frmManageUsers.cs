using InventoryManagement.Model;
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
    public partial class frmManageUsers : frmBase
    {
        List<UserViewModel> _users;
        public frmManageUsers()
        {
            InitializeComponent();

            DisplayUsers();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new frmManageUserDetails().ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void DisplayUsers()
        {
            _users = Singleton.Instance.UserModel.GetUsers();
            lvUsers.Items.Clear();
            lvUsers.LoadData(_users);



        }

        private void lvUsers_DoubleClick(object sender, EventArgs e)
        {
            var selected = lvUsers.SelectedItems[0];
            var id = Convert.ToInt32(selected.SubItems[1].Text);


            var dlg = new frmManageUserDetails(id);
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
            //DisplayUsers();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            var key = txtFilter.Text;
            var matches = from m in _users
                          where m.LastnameFirstNameUsername.ToUpper().Contains(key.ToUpper())

                          select m;
          
            lvUsers.LoadData(matches.ToList());
        }
    }
}
