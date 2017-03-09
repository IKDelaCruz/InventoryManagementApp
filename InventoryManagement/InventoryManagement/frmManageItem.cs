using BarcodeLib;
using InventoryManagement.Model;
using InventoryManagement.Repository;
using InventoryManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            isAddNewItem = AddItem;

            LoadComboBox();

            txtLastUpdate.Visible = !isAddNewItem;
            txtLastUpdatedUser.Visible = !isAddNewItem;
            txtCurrentValue.Visible = !isAddNewItem;
            lblLastUpdated.Visible = !isAddNewItem;
            lblLastUpdatedBy.Visible = !isAddNewItem;
            lblCurrentValue.Visible = !isAddNewItem;

            cbxStatus.SelectedItem = "Available";
            cbxCurrentOwner.SelectedValue = 0;

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
            cbxType.DisplayMember = "Name";
            cbxType.ValueMember = "Id";
            cbxType.DataSource = Singleton.Instance.ItemTypeModel.GetTypes();

            cbxSubType.DisplayMember = "Name";
            cbxSubType.ValueMember = "Id";
            cbxSubType.DataSource = Singleton.Instance.ItemSubTypeModel.GetSubTypesByType((int)cbxType.SelectedValue);

            cbxOS.DisplayMember = "Name";
            cbxOS.ValueMember = "Id";
            cbxOS.DataSource = Singleton.Instance.ItemModel.GetOSBySubtype();
            cbxOS.SelectedIndex = 0;

            cbxStatus.DataSource = Enum.GetValues(typeof(ItemStatus));
            cbxProcessor.DataSource = Enum.GetValues(typeof(ItemProcessors));
            cbxMemory.DataSource = Enum.GetValues(typeof(ItemMemory));
            cbxHDD1.DataSource = Enum.GetValues(typeof(ItemHDDCapacity));
            cbxHDD2.DataSource = Enum.GetValues(typeof(ItemHDDCapacity));

            cbxBrand.DisplayMember = "Name";
            cbxBrand.ValueMember = "Id";
            cbxBrand.DataSource = Singleton.Instance.ItemModel.GetBrandsBySubtype((int)cbxSubType.SelectedValue);

            cbxCurrentOwner.DisplayMember = "LastnameFirstName";
            cbxCurrentOwner.ValueMember = "Id";
            cbxCurrentOwner.DataSource = Singleton.Instance.UserModel.GetUsers();
            cbxCurrentOwner.SelectedIndex = 0;
        }
        private void DoSaveItem()
        {
            var brand = cbxBrand.SelectedValue;
            if (brand == null)
            {
                brand = 13;
            }
            else
            {
                brand = cbxBrand.SelectedValue;
            }

            var os = cbxOS.SelectedValue;
         

            var curowner = cbxCurrentOwner.SelectedValue;
           


            var itm = new ItemViewModel
            {

                Name = txtName.Text,
                Description = txtDescription.Text,
                TypeId = Convert.ToInt32(cbxType.SelectedValue),
                Type = cbxType.Text,
                SubTypeId = Convert.ToInt32(cbxSubType.SelectedValue),
                SubType = cbxSubType.Text,
                BrandId = (int)brand,
                Model = txtModel.Text,
                Serial = txtSerial.Text,
                Status = (ItemStatus)cbxStatus.SelectedItem,
                CurrentOwner = (int)curowner,
                SalvageValue = Convert.ToDecimal(txtSalvageValue.Text),
                LastUpdatedDate = DateTime.Now,
                LastUpdatedUserId = Singleton.Instance.UserModel.CurrentUser.Id,
                PurchaseDate = dtpPurchaseDate.Value,
                PurchasePrice = Convert.ToDecimal(txtPurchasePrice.Text),
                LifeSpan = Convert.ToInt32(txtLifetime.Text),
                Currentvalue = Convert.ToDecimal(txtCurrentValue.Text),
                OS = (int)os,
                Processor = (ItemProcessors)cbxProcessor.SelectedItem,
                Memory = (ItemMemory)cbxMemory.SelectedItem,
                HDD1 = (ItemHDDCapacity)cbxHDD1.SelectedItem,
                HDD2 = (ItemHDDCapacity)cbxHDD2.SelectedItem,
            };
            var result = new ReturnValueModel();

            if (isAddNewItem)
            {
                result = Singleton.Instance.ItemModel.CreateNewItem(itm, Singleton.Instance.UserModel.CurrentUser.Id);
                if (result.Success)
                    if (pbId.BackgroundImage == null) {
                        pbId.BackgroundImage = Image.FromFile(Utils.Helper.GetImageDirectory(@"\items\default.jpg"));
                        var img = pbId.BackgroundImage;
                        Singleton.Instance.ItemModel.UpdateItemImage(Convert.ToInt32(result.Param1), img);
                    }
                    else {
                        var img = pbId.BackgroundImage;
                        Singleton.Instance.ItemModel.UpdateItemImage(Convert.ToInt32(result.Param1), img);

                    }
            
                
                Singleton.Instance.TransactionModel.InsertLog(Singleton.Instance.UserModel.CurrentUser.Id, 0, ViewModel.TransactionType.CreateItem, "", itm.Id);
            }
            else
            {
                itm.Id = loadedItem.Id;
                result = Singleton.Instance.ItemModel.UpdateItem(itm, Singleton.Instance.UserModel.CurrentUser.Id);
              
                var img = new Bitmap(pbId.BackgroundImage);

                Singleton.Instance.ItemModel.UpdateItemImage(loadedItem.Id, img);
                Singleton.Instance.TransactionModel.InsertLog(Singleton.Instance.UserModel.CurrentUser.Id, 0, ViewModel.TransactionType.EditItem, "", itm.Id);
            }


            if (result.Success)
            {
                txtAssetTag.Text = result.Param2;
                this.DialogResult = DialogResult.OK;
                if (isAddNewItem)
                    MessageBox.Show("Item successfully created.");
                else
                    MessageBox.Show("Item successfully updated.");
            }
        }
        public void DoLoadItem(int itemId)
        {
            loadedItem = Singleton.Instance.ItemModel.GetItem(itemId);

            txtAssetTag.Text = loadedItem.AssetTag;
            txtName.Text = loadedItem.Name;
            txtDescription.Text = loadedItem.Description;
            cbxType.SelectedValue = loadedItem.TypeId;
            cbxSubType.SelectedValue = loadedItem.SubTypeId;
            cbxBrand.SelectedValue = loadedItem.BrandId;
            txtModel.Text = loadedItem.Model;
            txtSerial.Text = loadedItem.Serial;
            txtSalvageValue.Text = loadedItem.SalvageValue.ToString();

            cbxOS.SelectedValue = loadedItem.OS;
            cbxProcessor.Text = loadedItem.Processor.ToString();
            cbxMemory.Text = loadedItem.Memory.ToString();
            cbxHDD1.Text = loadedItem.HDD1.ToString();
            cbxHDD2.Text = loadedItem.HDD2.ToString();

            dtpPurchaseDate.Value = loadedItem.PurchaseDate;
            txtPurchasePrice.Text = ((decimal)loadedItem.PurchasePrice).ToString("n2");
            txtLifetime.Text = loadedItem.LifeSpan.ToString();
            txtCurrentValue.Text = ((decimal)loadedItem.Currentvalue).ToString("n2");
            txtSalvageValue.Text = ((decimal)loadedItem.SalvageValue).ToString("n2");

            txtLastUpdate.Text = loadedItem.LastUpdatedDate.ToString();

            cbxCurrentOwner.SelectedValue = loadedItem.CurrentOwner;
            cbxStatus.Text = ((ItemStatus)loadedItem.Status).ToString();

            if (Singleton.Instance.ItemModel.GetItemImage(itemId) != null)
            {
                var img = Singleton.Instance.ItemModel.GetItemImage(itemId);
                if (img != null) {
                    pbId.BackgroundImage = img;
                }
                          
            }

            var owner = Singleton.Instance.UserModel.GetUsersById(loadedItem.LastUpdatedUserId);

            txtLastUpdatedUser.Text = owner == null ? "SYSTEM" : owner.LastnameFirstName;

          
            //LoadTransactions(itemId);

        }

        //private void LoadTransactions(int itemId)
        //{
        //    dvLogs.DataSource = Singleton.Instance.TransactionModel.GetTransactionsByItemId(itemId);
        //}


        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (int)cbxType.SelectedValue;
            LoadSubtypes(selected);
        }
        private void LoadSubtypes(int categ)
        {
            cbxSubType.DisplayMember = "Name";
            cbxSubType.ValueMember = "Id";
            cbxSubType.DataSource = Singleton.Instance.ItemSubTypeModel.GetSubTypesByType((int)cbxType.SelectedValue);
        }
        private void LoadBrands()
        {
            cbxBrand.DataSource = null;

            cbxBrand.DisplayMember = "Name";
            cbxBrand.ValueMember = "Id";
            cbxBrand.DataSource = Singleton.Instance.ItemModel.GetBrandsBySubtype((int)cbxSubType.SelectedValue);
        }
        private void cbxSubType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBrands();
        }
        private void frmManageItem_Load(object sender, EventArgs e)
        {
            //load all transactions from transactions table

        }

        private void txtLifetime_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //disable space
            e.Handled = (e.KeyChar == (char)Keys.Space);
            //allows only numerical characters 
            var regex = new Regex(@"[^0-9\s]");
            if (!char.IsControl(e.KeyChar) && regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog openDlg = new OpenFileDialog();

                openDlg.InitialDirectory = "c:\\";
                openDlg.Filter = "image files |*.jpg; *.jpeg; *.png";
                openDlg.FilterIndex = 1;
                //openFileDialog1.RestoreDirectory = true;

                var res = openDlg.ShowDialog();

                if (res == DialogResult.OK)
                {
                    Image img = Image.FromFile(openDlg.FileName);
                    pbId.BackgroundImage = img;

                    
                }

            }
        }
        private void label24_Click(object sender, EventArgs e)
        {

        }
        private void txtSalvageValue_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
