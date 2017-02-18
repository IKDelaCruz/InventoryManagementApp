using InventoryManagement.Model;
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
using static InventoryManagement.Model.UserModel;

namespace InventoryManagement
{
    public partial class frmManageUserInfo : frmBase
    {
        bool isUpdate;
        UserViewModel currentUSer;

        public frmManageUserInfo(int userId = 0)
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;

            LoadComboValues();
            if (userId > 0)
            {
                LoadUserInfo(userId);
                isUpdate = true;

            }
            //load existing values to update/edit
        }
        private void LoadComboValues()
        {
            cbxUserType.DataSource = Enum.GetValues(typeof(UserType));

            cbxCompany.ValueMember = "Id";
            cbxCompany.DisplayMember = "Name";
            cbxCompany.DataSource = Singleton.Instance.CompanyDepartmentModel.GetCompanies();

            cbxDepartment.ValueMember = "Id";
            cbxDepartment.DisplayMember = "Name";
            cbxDepartment.DataSource = Singleton.Instance.CompanyDepartmentModel.GetDepartments((int)cbxCompany.SelectedValue);

        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            var result = Singleton.Instance.UserModel.GetUsersByUsername(txtUsername.Text);
            var un = txtUsername.Text;
            var password = txtPassord.Text;
            if (string.IsNullOrWhiteSpace(un))
            {
                MessageBox.Show("Invalid Username", "Invalid",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Invalid Password", "Invalid",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                if (isUpdate)
                {
                    if (Singleton.Instance.UserModel.UpdateUser(currentUSer.Id, txtFirstname.Text, txtLastname.Text, (int)cbxCompany.SelectedValue, (int)cbxDepartment.SelectedValue,
                        (UserType)cbxUserType.SelectedItem))
                    {
                        MessageBox.Show("User successfully updated!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    
                }
                else
                {
                    if (result != null)
                    {
                        MessageBox.Show("Username already exists!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    var id = Singleton.Instance.UserModel.CreateNewUser(txtUsername.Text, txtPassord.Text, (UserType)cbxUserType.SelectedItem, txtFirstname.Text, txtLastname.Text, (int)cbxDepartment.SelectedValue);
                    if (Singleton.Instance.UserModel.UpdateUser(id, txtFirstname.Text, txtLastname.Text, (int)cbxCompany.SelectedValue, (int)cbxDepartment.SelectedValue,
                        (UserType)cbxUserType.SelectedItem))
                    {
                        MessageBox.Show("User successfully created!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    }
                    
                }

            }
        }




            
        private void cbxCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDepartment.ValueMember = "Id";
            cbxDepartment.DisplayMember = "Name";
            cbxDepartment.DataSource = Singleton.Instance.CompanyDepartmentModel.GetDepartments((int)cbxCompany.SelectedValue);
        }
        private void LoadUserInfo(int userId)
        {
            var info = Singleton.Instance.UserModel.GetUsersById(userId);
            currentUSer = info;

            if (info != null)
            {
                txtFirstname.Text = info.Firstname;
                txtLastname.Text = info.Lastname;

                txtUsername.Text = info.Username;
                txtUsername.Enabled = false;

                txtPassord.Text = info.Password;
                txtPassord.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
