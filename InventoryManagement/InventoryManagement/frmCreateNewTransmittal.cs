using InventoryLib.ViewModel;
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
    public partial class frmCreateNewTransmittal : Form
    {
        List<ItemViewModel> _items;
        public frmCreateNewTransmittal()
        {
            _items = new List<ItemViewModel>();
            InitializeComponent();
            LoadCompany();
            dvItems.AutoGenerateColumns = false;
        }
        private void cbxCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDepartment.ValueMember = "Id";
            cbxDepartment.DisplayMember = "Name";
            cbxDepartment.DataSource = Singleton.Instance.CompanyDepartmentModel.GetDepartments((int)cbxCompany.SelectedValue);
        }
        private void LoadCompany()
        {
            cbxApproved.ValueMember = "Id";
            cbxApproved.DisplayMember = "LastnameFirstNameUsername";
            cbxApproved.DataSource = Singleton.Instance.UserModel.GetUsersByDepartmentId(1);

            cbxPrepared.ValueMember = "Id";
            cbxPrepared.DisplayMember = "LastnameFirstNameUsername";
            cbxPrepared.DataSource = Singleton.Instance.UserModel.GetUsersByDepartmentId(1);

            cbxCompany.ValueMember = "Id";
            cbxCompany.DisplayMember = "Name";
            cbxCompany.DataSource = Singleton.Instance.CompanyDepartmentModel.GetCompanies();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var search = new frmItemSearch();
            var result = search.ShowDialog();
            if (result == DialogResult.OK)
            {
                foreach(int id in search.ReturnIntList)
                {
                    var item = Singleton.Instance.ItemModel.GetItem(id);
                    _items.Add(item);
                }
                RefreshList();
            }
        }
        private void RefreshList()
        {
            dvItems.DataSource = null;
            dvItems.DataSource = _items;
        }
        private void btbDelete_Click(object sender, EventArgs e)
        {
            if (dvItems.SelectedRows.Count == 0)
                return;

            foreach(DataGridViewRow dr in dvItems.SelectedRows)
            {
                var id = dr.Cells[0].Value;
                _items.Remove(_items.FirstOrDefault(h => h.Id == (int)id));
            }
          
            RefreshList();
        }

        private void cbxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxUsers.ValueMember = "Id";
            cbxUsers.DisplayMember = "LastnameFirstNameUsername";
            var id = (int)cbxDepartment.SelectedValue;
            cbxUsers.DataSource = Singleton.Instance.UserModel.GetUsersByDepartmentId(id);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var transmittal = new TransmittalViewModel();

            transmittal.ApprovedById = (int)cbxApproved.SelectedValue;
            transmittal.ApprovedDate = dtpApprovedDate.Value;
            transmittal.CreatedDate = DateTime.Now;
            transmittal.PreparedById = (int)cbxPrepared.SelectedValue;
            transmittal.TransmittedToCompanyId = (int)cbxCompany.SelectedValue;
            transmittal.TransmittedToDepartmentId = (int)cbxDepartment.SelectedValue;
            transmittal.TransmittedToUserId = (int)cbxUsers.SelectedValue;

            foreach(DataGridViewRow dr in dvItems.Rows)
            {
                transmittal.TransmittalItems.Add(new TransmittalItemViewModel
                {
                    ItemId = Convert.ToInt32(dr.Cells[0].Value.ToString()),
                    Quantity = 1
                });
            }
            

            var result = Singleton.Instance.TransmittalModel.InsertTransmittal(transmittal);

            if (result)
                this.DialogResult = DialogResult.OK;

            this.Close();

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
