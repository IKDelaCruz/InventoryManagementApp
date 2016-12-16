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
    public partial class frmManageItem : frmBase
    {
        private bool isAddItem;
        public frmManageItem(bool AddItem = true)
        {
            InitializeComponent();

            isAddItem = AddItem;

            LoadComboBox();

            txtLastUpdate.Visible = !isAddItem;
            txtLastUpdatedUser.Visible = !isAddItem;
            txtCurrentValue.Visible = !isAddItem;
            lblLastUpdated.Visible = !isAddItem;
            lblLastUpdatedBy.Visible = !isAddItem;
            lblCurrentValue.Visible = !isAddItem;

        }
        private void LoadComboBox()
        {
            cbxType.DataSource = Enum.GetValues(typeof(PrimaryItemType));
            cbxSubType.DataSource = Enum.GetValues(typeof(SecondaryItemType));
            cbxStatus.DataSource = Enum.GetValues(typeof(ItemStatus));

            cbxBrand.DisplayMember = "Name";
            cbxBrand.ValueMember = "Id";
            cbxBrand.DataSource = Singleton.Instance.ItemModel.GetBrands();

            cbxCurrentOwner.DisplayMember = "LastnameFirstName";
            cbxCurrentOwner.ValueMember = "Id";
            cbxCurrentOwner.DataSource = Singleton.Instance.UserModel.GetUsers();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var itm = new ItemViewModel
            {
                Name = txtName.Text,
                Description = txtDescription.Text,
                Type = (PrimaryItemType)cbxType.SelectedItem,
                SubType = (SecondaryItemType)cbxSubType.SelectedItem,
                BrandId = (int)cbxBrand.SelectedValue,
                Model = txtModel.Text,
                Serial = txtSerial.Text,
                Status = (ItemStatus)cbxStatus.SelectedItem,
                CurrentOwner = (int)cbxCurrentOwner.SelectedValue,
                LastUpdatedDate = DateTime.Now,
                LastUpdatedUserId = Singleton.Instance.UserModel.CurrentUser.Id,
                PurchaseDate = dtpPurchaseDate.Value,
                PurchasePrice = Convert.ToDecimal(txtPurchasePrice.Text),
                LifeSpan = int.Parse(txtLifetime.Text),
                Currentvalue = Convert.ToDecimal(txtPurchasePrice.Text)
            };
            var result = Singleton.Instance.ItemModel.CreateNewItem(itm, Singleton.Instance.UserModel.CurrentUser.Id);

            if (result)
            {
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Item successfully created.");
            }

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
