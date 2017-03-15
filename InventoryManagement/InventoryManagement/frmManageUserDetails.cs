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
using static InventoryManagement.Model.UserModel;

namespace InventoryManagement
{
    public partial class frmManageUserDetails : frmBase
    {
        bool isUpdate;
        UserViewModel currentUSer;

        public frmManageUserDetails(int userId = 0)
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
            dvLogs.AutoGenerateColumns = false;
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
            DoSaveUser();
        }
        private void DoSaveUser()
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Invalid Username", "Invalid",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(password) && !isUpdate)
            {
                MessageBox.Show("Invalid Password", "Invalid",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (isUpdate)
                {

                    if (Singleton.Instance.UserModel.UpdateUser(currentUSer.Id, txtFirstname.Text, txtLastname.Text, (int)cbxCompany.SelectedValue, (int)cbxDepartment.SelectedValue, (UserType)cbxUserType.SelectedItem, txtPassword.Text))
                    {
                        MessageBox.Show("User successfully updated!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                }
                else
                {
                    var result = Singleton.Instance.UserModel.GetUsersByUsername(txtUsername.Text);
                    if (result != null)
                    {
                        MessageBox.Show("Username already exists!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var id = Singleton.Instance.UserModel.CreateNewUser(txtUsername.Text, txtPassword.Text, (UserType)cbxUserType.SelectedItem, txtFirstname.Text, txtLastname.Text, (int)cbxDepartment.SelectedValue);

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

            Text = string.Format("Manage User :: {0} | {1}/{2}", info.LastnameFirstName,info.Company, info.Department);

            currentUSer = info;

            if (info != null)
            {
                txtFirstname.Text = info.Firstname;
                txtLastname.Text = info.Lastname;

                txtUsername.Text = info.Username;
                txtUsername.Enabled = false;

                txtPassword.Text = info.Password;
                //txtPassord.Enabled = false;
                cbxUserType.SelectedItem = (UserType)info.UserType;
                cbxCompany.SelectedValue = info.CompanyId;
                cbxDepartment.SelectedValue = info.DepartmentId;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grpUser_Enter(object sender, EventArgs e)
        {

        }

        private void frmManageUserInfo_Load(object sender, EventArgs e)
        {
            var itms = Singleton.Instance.ItemModel.GetItemsByOwner(currentUSer.Id).OrderBy(h => h.Name).ToList();

            imgMainImage.Images.Clear();
            var images = Singleton.Instance.ItemSubTypeModel.GetItemSubTypeImages();
            foreach (ItemSubTypeViewModel x in images)
                imgMainImage.Images.Add(x.ParentId.ToString(), x.Picture);

            int index = 0;
            if (lvMain.SelectedIndices.Count > 0)
                index = lvMain.SelectedIndices[0];

            lvMain.LoadData(itms, imgMainImage);

            if (lvMain.Items.Count > 0 && false)
            {
                lvMain.Items[index].Selected = true;
                lvMain.Focus();
            }
        }
        private void lvMain_DoubleClick(object sender, EventArgs e)
        {
            DoManageItem();
        }
        private void DoManageItem()
        {
            var selected = lvMain.SelectedItems[0];
            var id = Convert.ToInt32(selected.SubItems[1].Text);


            var dlg = new frmManageItemDetails(id, false);
            dlg.ShowDialog();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadLogs();
        }
        private void LoadLogs()
        {
            var from = dtpFrom.Value.Date;
            var to = dtpTo.Value.Date.AddDays(1);

            var data = Model.Singleton.Instance.TransactionModel.GetTransactions(from, to, 0, currentUSer.Id);
            
            var list = new Utils.MySortableBindingList<TransactionViewModel>(data);

            dvLogs.DataSource = list;
        }
    }
}
