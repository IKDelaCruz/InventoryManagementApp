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
using static InventoryManagement.Model.UserModel;

namespace InventoryManagement
{
    public partial class frmManageUserInfo : frmBase
    {
        public frmManageUserInfo()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;

            LoadComboValues();
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
            var id = Singleton.Instance.UserModel.CreateNewUser(txtUsername.Text, txtPassord.Text, (UserType)cbxUserType.SelectedItem);
            if (Singleton.Instance.UserModel.UpdateUser(id, txtFirstname.Text, txtLastname.Text, (int)cbxCompany.SelectedValue, (int)cbxDepartment.SelectedValue))
            {
                MessageBox.Show("User successfully created!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cbxCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDepartment.ValueMember = "Id";
            cbxDepartment.DisplayMember = "Name";
            cbxDepartment.DataSource = Singleton.Instance.CompanyDepartmentModel.GetDepartments((int)cbxCompany.SelectedValue);
        }
    }
}
