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
        List<ItemViewModel> _selectedItem;
        TransactionType _transType;
        public frmQuickTransaction(List<ItemViewModel> selectedItem, TransactionType transType)
        {
            InitializeComponent();
            _selectedItem = selectedItem;
            _transType = transType;


            if (transType == TransactionType.BorrowItem)
            {
                lblHeader.Text = "Borrow Item";
                dtpTo.Value = DateTime.Now.AddDays(30);
            }
          
            else if (transType == TransactionType.ReturnItem)
            {
                lblHeader.Text = "Return Item";
            }
            else if (transType == TransactionType.DisposeItem)
                lblHeader.Text = "Retire Item";
            else if (transType == TransactionType.RepairItem)
                lblHeader.Text = "Repair Item";
            else if (transType == TransactionType.AssignItem)
            {
                lblHeader.Text = "Assign Item";
                dtpTo.Value = DateTime.Now.AddYears(5);
            }

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
                var firstItem = _selectedItem[0];
                cbxCompany.SelectedValue = firstItem.CurrentCompany == 0 ? 1 : firstItem.CurrentCompany;
                cbxDepartment.SelectedValue = firstItem.CurrentDepartment == 0 ? 1 : firstItem.CurrentDepartment;
                cbxUser.SelectedValue = firstItem.CurrentOwner == 0 ? 1 : firstItem.CurrentOwner;
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

        private void UpdateItemStatus(int itemId, ItemStatus currentStatus, ItemStatus newStatus, int userId)
        {
            ItemModel itm = new ItemModel();
            Singleton.Instance.ItemModel.UpdateItemStatus(itemId, userId, currentStatus, newStatus, dtpTo.Value);
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

        private void btn_OK_Clicked(object sender, EventArgs e)
        {
            foreach (ItemViewModel lvi in _selectedItem)
            {
                if (_transType == TransactionType.AssignItem)
                {
                    UpdateItemStatus(lvi.Id, lvi.Status, ItemStatus.Assigned, (int)cbxUser.SelectedValue);

                }
                if (_transType == TransactionType.BorrowItem)
                {

                    UpdateItemStatus(lvi.Id, lvi.Status, ItemStatus.Borrowed, (int)cbxUser.SelectedValue);

                }
                else if (_transType == TransactionType.ReserveItem)
                {
                    UpdateItemStatus(lvi.Id, lvi.Status, ItemStatus.Reserved, (int)cbxUser.SelectedValue);
              
                }
                else if (_transType == TransactionType.ReturnItem)
                {
                    UpdateItemStatus(lvi.Id, lvi.Status, ItemStatus.Available, 0);
                  
                }
                else if (_transType == TransactionType.DisposeItem)
                {
                    //433 - disposed username
                    UpdateItemStatus(lvi.Id, lvi.Status, ItemStatus.Disposed, 433);
                  
                }
                else if (_transType == TransactionType.RepairItem)
                {
                    //432 - repairman username
                    UpdateItemStatus(lvi.Id, lvi.Status, ItemStatus.Broken, 432);
                  
                }
                Singleton.Instance.TransactionModel.InsertLog(Singleton.Instance.UserModel.CurrentUser.Id, (int)(cbxUser.SelectedValue ?? 0), _transType, txtRemarks.Text, lvi.Id);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
