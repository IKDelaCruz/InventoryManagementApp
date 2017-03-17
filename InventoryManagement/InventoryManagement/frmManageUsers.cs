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

            LoadCompany();
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
            var u = _users;
            var key = txtFilter.Text;

            var matches = from m in u
                          where m.LastnameFirstNameUsername.ToUpper().Contains(key.ToUpper())

                          select m;
          
            lvUsers.LoadData(matches.ToList());
        }

        private void cbxCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDepartment.ValueMember = "Id";
            cbxDepartment.DisplayMember = "Name";
            cbxDepartment.DataSource = Singleton.Instance.CompanyDepartmentModel.GetDepartments((int)cbxCompany.SelectedValue);
        }
        private void LoadCompany()
        {
            cbxCompany.ValueMember = "Id";
            cbxCompany.DisplayMember = "Name";
            cbxCompany.DataSource = Singleton.Instance.CompanyDepartmentModel.GetCompanies();
        }

        private void cbxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            _users = Singleton.Instance.UserModel.GetUsersByDepartmentId((int)cbxDepartment.SelectedValue);
            lvUsers.Items.Clear();
            lvUsers.LoadData(_users);
        }
    }
}
