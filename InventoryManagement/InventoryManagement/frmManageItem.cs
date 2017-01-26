using BarcodeLib;
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
        private bool isAddNewItem;
        private ItemViewModel loadedItem;
        public frmManageItem(int itemId = 0, bool AddItem = true)
        {
            InitializeComponent();
            dvLogs.AutoGenerateColumns = false;

            isAddNewItem = AddItem;

            LoadComboBox();

            txtLastUpdate.Visible = !isAddNewItem;
            txtLastUpdatedUser.Visible = !isAddNewItem;
            txtCurrentValue.Visible = !isAddNewItem;
            lblLastUpdated.Visible = !isAddNewItem;
            lblLastUpdatedBy.Visible = !isAddNewItem;
            lblCurrentValue.Visible = !isAddNewItem;

            if (!isAddNewItem)
                DoLoadItem(itemId);

        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            DoSaveItem();
        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrintBarcode_Click(object sender, EventArgs e)
        {
          

        }

        private void LoadComboBox()
        {
            cbxType.DataSource = Enum.GetValues(typeof(PrimaryItemType));
            cbxSubType.DataSource = Enum.GetValues(typeof(SecondaryItemType));
            cbxStatus.DataSource = Enum.GetValues(typeof(ItemStatus));

            cbxOS.DataSource = Enum.GetValues(typeof(ItemOperatingSystem));
            cbxProcessor.DataSource = Enum.GetValues(typeof(ItemProcessors));
            cbxMemory.DataSource = Enum.GetValues(typeof(ItemMemory));
            cbxHDD1.DataSource = Enum.GetValues(typeof(ItemHDDCapacity));
            cbxHDD2.DataSource = Enum.GetValues(typeof(ItemHDDCapacity));

            cbxBrand.DisplayMember = "Name";
            cbxBrand.ValueMember = "Id";
            cbxBrand.DataSource = Singleton.Instance.ItemModel.GetBrands();

            cbxCurrentOwner.DisplayMember = "LastnameFirstName";
            cbxCurrentOwner.ValueMember = "Id";
            cbxCurrentOwner.DataSource = Singleton.Instance.UserModel.GetUsers();
        }
        private void DoSaveItem()
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
                Currentvalue = Convert.ToDecimal(txtPurchasePrice.Text),
                OS = (ItemOperatingSystem)cbxOS.SelectedItem,
                Processor = (ItemProcessors)cbxProcessor.SelectedItem,
                Memory = (ItemMemory)cbxMemory.SelectedItem,
                HDD1 = (ItemHDDCapacity)cbxHDD1.SelectedItem,
                HDD2 = (ItemHDDCapacity)cbxHDD2.SelectedItem,
            };
            var result = new ReturnValueModel();

            if (isAddNewItem)
            {
                result = Singleton.Instance.ItemModel.CreateNewItem(itm, Singleton.Instance.UserModel.CurrentUser.Id);
                Singleton.Instance.TransactionModel.InsertLog(Singleton.Instance.UserModel.CurrentUser.Id, 0, ViewModel.TransactionType.CreateItem, "", itm.Id);
            }
            else
            {
                itm.Id = loadedItem.Id;
                result = Singleton.Instance.ItemModel.UpdateItem(itm, Singleton.Instance.UserModel.CurrentUser.Id);
                Singleton.Instance.TransactionModel.InsertLog(Singleton.Instance.UserModel.CurrentUser.Id, 0, ViewModel.TransactionType.EditItem, "", itm.Id);
            }
                

            if (result.Success)
            {
                txtAssetTag.Text = result.Param2;
                this.DialogResult = DialogResult.OK;
                if(isAddNewItem)
                    MessageBox.Show("Item successfully created.");
                else
                    MessageBox.Show("Item successfully updated.");
            }
        }
        private void DoLoadItem(int itemId)
        {
            loadedItem = Singleton.Instance.ItemModel.GetItem(itemId);

            txtAssetTag.Text = loadedItem.AssetTag;
            txtName.Text = loadedItem.Name;
            txtDescription.Text = loadedItem.Description;
            cbxType.Text = loadedItem.Type.ToString();
            cbxSubType.Text = loadedItem.SubType.ToString();
            cbxBrand.Text = loadedItem.Brand.ToString();
            txtModel.Text = loadedItem.Model;
            txtSerial.Text = loadedItem.Serial;

            cbxOS.Text = loadedItem.OS.ToString();
            cbxProcessor.Text = loadedItem.Processor.ToString();
            cbxMemory.Text = loadedItem.Memory.ToString();
            cbxHDD1.Text = loadedItem.HDD1.ToString();
            cbxHDD2.Text = loadedItem.HDD2.ToString();

            dtpPurchaseDate.Value = loadedItem.PurchaseDate;
            txtPurchasePrice.Text = ((decimal)loadedItem.PurchasePrice).ToString("n2");
            txtLifetime.Text = loadedItem.LifeSpan.ToString();
            txtCurrentValue.Text = ((decimal)loadedItem.Currentvalue).ToString("n2");

            txtLastUpdate.Text = loadedItem.LastUpdatedDate.ToString();

            cbxCurrentOwner.SelectedValue = loadedItem.CurrentOwner;
            cbxStatus.Text = ((ItemStatus)loadedItem.Status).ToString();

            var owner = Singleton.Instance.UserModel.GetUsersById(loadedItem.LastUpdatedUserId);

            txtLastUpdatedUser.Text = owner == null ? "SYSTEM" : owner.LastnameFirstName;
            LoadTransactions(itemId);
        }
        private void LoadTransactions(int itemId)
        {
            dvLogs.DataSource = Singleton.Instance.TransactionModel.GetTransactionsByItemId(itemId);
        }
    }
}
