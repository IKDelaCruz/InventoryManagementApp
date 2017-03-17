using BarcodeLib;
using InventoryManagement.Model;
using InventoryManagement.Repository;
using InventoryManagement.Utils;
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
    public partial class frmManageItemDetails : frmBase
    {
        private bool _isAddNewItem;
        private ItemViewModel _loadedItem;

        public frmManageItemDetails(int itemId = 0, bool addNewItem = true)
        {
            InitializeComponent();

            dvLogs.AutoGenerateColumns = false;
            _isAddNewItem = addNewItem;

            LoadComboBox();

            txtLastUpdate.Visible = !_isAddNewItem;
            txtLastUpdatedUser.Visible = !_isAddNewItem;
            txtCurrentValue.Visible = !_isAddNewItem;
            lblLastUpdated.Visible = !_isAddNewItem;
            lblLastUpdatedBy.Visible = !_isAddNewItem;
            lblCurrentValue.Visible = !_isAddNewItem;

            cbxStatus.SelectedItem = "Available";

            if (!_isAddNewItem)
            {
                DoLoadItem(itemId);

            }

            if (_isAddNewItem)
            {
                tabControl1.TabPages.RemoveAt(5);
            }

            dtpFrom.Value = DateTime.Now.AddDays(-30);
            dtpTo.Value = DateTime.Now.AddDays(1);

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
            cbxLoginType.DataSource = Enum.GetValues(typeof(ItemLoginType));
            cbxPrinterType.DataSource = Enum.GetValues(typeof(PrinterType));


            cbxBrand.DisplayMember = "Name";
            cbxBrand.ValueMember = "Id";
            cbxBrand.DataSource = Singleton.Instance.ItemModel.GetBrandsBySubtype((int)cbxSubType.SelectedValue);

            LoadUsers();



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
                LoginType = (ItemLoginType)cbxLoginType.SelectedItem,
                PrinterType = (PrinterType)cbxPrinterType.SelectedItem,
                NetworkIP = txtNetworkIp.Text,
                NetworkSubnet = txtSubnet.Text,
                NetworkGateway = txtGateway.Text

            };
            var result = new ReturnValueModel();

            if (_isAddNewItem)
            {

                result = Singleton.Instance.ItemModel.CreateNewItem(itm, Singleton.Instance.UserModel.CurrentUser.Id);


                if (result.Success)
                    if (pbId.BackgroundImage == null)
                    {
                        pbId.BackgroundImage = Image.FromFile(Utils.Helper.GetImageDirectory(@"\items\default.jpg"));
                        var img = pbId.BackgroundImage;
                        Singleton.Instance.ItemModel.UpdateItemImage(Convert.ToInt32(result.Param1), img);
                    }
                    else
                    {
                        var img = pbId.BackgroundImage;
                        Singleton.Instance.ItemModel.UpdateItemImage(Convert.ToInt32(result.Param1), img);

                    }


                Singleton.Instance.TransactionModel.InsertLog(Singleton.Instance.UserModel.CurrentUser.Id, 0, ViewModel.TransactionType.CreateItem, "", itm.Id);
            }
            else
            {
                itm.Id = _loadedItem.Id;
                result = Singleton.Instance.ItemModel.UpdateItem(itm, Singleton.Instance.UserModel.CurrentUser.Id);

                var img = new Bitmap(pbId.BackgroundImage);

                Singleton.Instance.ItemModel.UpdateItemImage(_loadedItem.Id, img);
                Singleton.Instance.TransactionModel.InsertLog(Singleton.Instance.UserModel.CurrentUser.Id, 0, ViewModel.TransactionType.EditItem, "", itm.Id);
            }


            if (result.Success)
            {
                txtAssetTag.Text = result.Param2;
                this.DialogResult = DialogResult.OK;
                if (_isAddNewItem)
                    MessageBox.Show("Item successfully created.");
                else
                    MessageBox.Show("Item successfully updated.");
            }
        }
        public void DoLoadItem(int itemId)
        {

            _loadedItem = Singleton.Instance.ItemModel.GetItem(itemId);

            Text = string.Format("Manage Item :: {0}({1})", _loadedItem.Name, _loadedItem.CurrentOwnerName);

            txtAssetTag.Text = _loadedItem.AssetTag;
            txtName.Text = _loadedItem.Name;
            txtDescription.Text = _loadedItem.Description;
            cbxType.SelectedValue = _loadedItem.TypeId;
            cbxSubType.SelectedValue = _loadedItem.SubTypeId;
            cbxBrand.SelectedValue = _loadedItem.BrandId;
            txtModel.Text = _loadedItem.Model;
            txtSerial.Text = _loadedItem.Serial;
            txtSalvageValue.Text = _loadedItem.SalvageValue.ToString();

            cbxOS.SelectedValue = (_loadedItem.OS == 0) ? 1 : _loadedItem.OS;
            cbxProcessor.Text = _loadedItem.Processor.ToString();
            cbxMemory.Text = _loadedItem.Memory.ToString();
            cbxHDD1.Text = _loadedItem.HDD1.ToString();
            cbxHDD2.Text = _loadedItem.HDD2.ToString();

            dtpPurchaseDate.Value = _loadedItem.PurchaseDate;
            txtPurchasePrice.Text = ((decimal)_loadedItem.PurchasePrice).ToString("n2");
            txtLifetime.Text = _loadedItem.LifeSpan.ToString();
            txtCurrentValue.Text = ((decimal)_loadedItem.Currentvalue).ToString("n2");
            txtSalvageValue.Text = ((decimal)_loadedItem.SalvageValue).ToString("n2");

            txtLastUpdate.Text = _loadedItem.LastUpdatedDate.ToString();

            txtCompany.Text = _loadedItem.CurrentCompanyName ?? "";
            txtDepartment.Text = _loadedItem.CurrentDepartmentName ?? "";
            txtEmployee.Text = _loadedItem.CurrentOwnerName;

            cbxStatus.Text = ((ItemStatus)_loadedItem.Status).ToString();
            cbxLoginType.Text = _loadedItem.LoginType.ToString();
            if (Singleton.Instance.ItemModel.GetItemImage(itemId) != null)
            {
                var img = Singleton.Instance.ItemModel.GetItemImage(itemId);
                if (img != null)
                {
                    pbId.BackgroundImage = img;
                }

            }

            var owner = Singleton.Instance.UserModel.GetUsersById(_loadedItem.LastUpdatedUserId);

            txtLastUpdatedUser.Text = owner == null ? "SYSTEM" : owner.LastnameFirstName;
            cbxPrinterType.Text = ((PrinterType)_loadedItem.PrinterType).ToString();
            cbxLoginType.Text = ((ItemLoginType)_loadedItem.LoginType).ToString();

            txtNetworkIp.Text = _loadedItem.NetworkIP;
            txtSubnet.Text = _loadedItem.NetworkSubnet;
            txtGateway.Text = _loadedItem.NetworkGateway;



        }



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

                //openDlg.InitialDirectory = "c:\\";
                openDlg.Filter = "image files |*.jpg; *.jpeg; *.png";
                openDlg.FilterIndex = 1;
                //openFileDialog1.RestoreDirectory = true;

                var res = openDlg.ShowDialog();

                if (res == DialogResult.OK)
                {
                    Image img = Image.FromFile(openDlg.FileName);
                    txtFilename.Text = openDlg.FileName;
                    var newImage = ImageCon.ScaleImage(img, 500, 500);

                    pbId.BackgroundImage = newImage;


                }

            }
        }
        private void label24_Click(object sender, EventArgs e)
        {

        }
        private void txtSalvageValue_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadUsers();
        }
        private void LoadUsers()
        {

        }
        private void LoadHistory()
        {
            var from = dtpFrom.Value.Date;
            var to = dtpTo.Value.Date.AddDays(1);

            var data = Model.Singleton.Instance.TransactionModel.GetTransactions(from, to, _loadedItem.Id);
            var list = new Utils.MySortableBindingList<TransactionViewModel>(data);

            dvLogs.DataSource = list;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void cbxCompany_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
