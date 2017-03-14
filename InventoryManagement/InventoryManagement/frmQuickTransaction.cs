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

namespace InventoryManagement
{
    public partial class frmQuickTransaction : Form
    {
        ItemViewModel _selectedItem;
        TransactionType _transType;
        public frmQuickTransaction(ItemViewModel selectedItem, TransactionType transType)
        {
            InitializeComponent();
            _selectedItem = selectedItem;
            _transType = transType;

            if (transType == TransactionType.BorrowItem)
                lblHeader.Text = "Borrow Item";
            else if (transType == TransactionType.ReserveItem)
                lblHeader.Text = "Reserve Item";
            else if (transType == TransactionType.ReturnItem)
                lblHeader.Text = "Return Item";
            else if (transType == TransactionType.DisposeItem)
                lblHeader.Text = "Retire Item";
            else if (transType == TransactionType.RepairItem)
                lblHeader.Text = "Repair Item";

        }

        private void frmQuickTransaction_Load(object sender, EventArgs e)
        {
            cbxCompany.ValueMember = "Id";
            cbxCompany.DisplayMember = "Name";
            cbxCompany.DataSource = Singleton.Instance.CompanyDepartmentModel.GetCompanies();

            cbxCompany.Enabled = false;
            cbxDepartment.Enabled = false;
            cbxUser.Enabled = false;

            if (_transType == TransactionType.ReturnItem)
            {
                cbxCompany.SelectedValue = _selectedItem.CurrentCompany == 0 ? 1 : _selectedItem.CurrentCompany;
                cbxDepartment.SelectedValue = _selectedItem.CurrentDepartment == 0 ? 1 : _selectedItem.CurrentDepartment;
                cbxUser.SelectedValue = _selectedItem.CurrentOwner == 0 ? 1 : _selectedItem.CurrentOwner;
            }
            else if (_transType == TransactionType.RepairItem)
            {
                cbxCompany.SelectedValue = 1;
                cbxDepartment.SelectedValue = 1;
                cbxUser.SelectedValue = 432;
            }
            else if (_transType == TransactionType.DisposeItem)
            {
                cbxCompany.SelectedValue = 1;
                cbxDepartment.SelectedValue = 1;
                cbxUser.SelectedValue = 433;
            }
            else
            {
                cbxCompany.Enabled = true;
                cbxDepartment.Enabled = true;
                cbxUser.Enabled = true;
            }
        }

        private void UpdateItemStatus(ItemStatus currentStatus, ItemStatus newStatus, int userId)
        {
            if (_selectedItem != null)
            {
                ItemModel itm = new ItemModel();
                Singleton.Instance.ItemModel.UpdateItemStatus(_selectedItem.Id, userId, currentStatus, newStatus);

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

        private void cbxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadUsers();
        }
        private void LoadUsers()
        {
            if (cbxDepartment.SelectedValue == null)
                return;

            cbxUser.DataSource = null;
            cbxUser.DisplayMember = "LastnameFirstName";
            cbxUser.ValueMember = "Id";

            cbxUser.DataSource = Singleton.Instance.UserModel.GetUsersByDepartmentId((int)cbxDepartment.SelectedValue);

            cbxUser.SelectedIndex = 0;
        }

        private void btnReserve_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheckin_Click_1(object sender, EventArgs e)
        {
            if (_transType == TransactionType.BorrowItem)
            {
                UpdateItemStatus(_selectedItem.Status, ItemStatus.Borrowed, (int)cbxUser.SelectedValue);
                Singleton.Instance.TransactionModel.InsertLog(Singleton.Instance.UserModel.CurrentUser.Id, (int)cbxUser.SelectedValue, ViewModel.TransactionType.BorrowItem, "", _selectedItem.Id);
            }
            else if (_transType == TransactionType.ReserveItem)
            {
                UpdateItemStatus(_selectedItem.Status, ItemStatus.Reserved, (int)cbxUser.SelectedValue);
                Singleton.Instance.TransactionModel.InsertLog(Singleton.Instance.UserModel.CurrentUser.Id, (int)cbxUser.SelectedValue, ViewModel.TransactionType.ReserveItem, "", _selectedItem.Id);
            }
            else if (_transType == TransactionType.ReturnItem)
            {
                UpdateItemStatus(_selectedItem.Status, ItemStatus.Available, 0);
                Singleton.Instance.TransactionModel.InsertLog(Singleton.Instance.UserModel.CurrentUser.Id, (int)cbxUser.SelectedValue, ViewModel.TransactionType.ReturnItem, "", _selectedItem.Id);
            }
            else if (_transType == TransactionType.DisposeItem)
            {
                //433 - disposed username
                UpdateItemStatus(_selectedItem.Status, ItemStatus.Disposed, 433);
                Singleton.Instance.TransactionModel.InsertLog(Singleton.Instance.UserModel.CurrentUser.Id, (int)cbxUser.SelectedValue, ViewModel.TransactionType.DisposeItem, "", _selectedItem.Id);
            }
            else if (_transType == TransactionType.RepairItem)
            {
                //432 - repairman username
                UpdateItemStatus(_selectedItem.Status, ItemStatus.Broken, 432);
                Singleton.Instance.TransactionModel.InsertLog(Singleton.Instance.UserModel.CurrentUser.Id, (int)cbxUser.SelectedValue, ViewModel.TransactionType.RepairItem, "", _selectedItem.Id);
            }

        }
    }
}
