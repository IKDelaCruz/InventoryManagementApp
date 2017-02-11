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
using InventoryManagement.Utils;
using InventoryManagement.ViewModel;
using BarcodeLib;

namespace InventoryManagement
{
    public partial class frmMain : frmBase
    {
        ItemViewModel _selectedItem;
        public frmMain()
        {
            InitializeComponent();
            fillcombo();
      
        }

        private void fillcombo() {
            cbxStatus.DataSource = Enum.GetValues(typeof(ItemStatus));
            // cbxType.DataSource = Enum.GetValues(typeof(PrimaryItemType));
            // cbxSubtype.DataSource = Enum.GetValues(typeof(SecondaryItemType));

            cbxType.DisplayMember = "Name";
            cbxType.ValueMember = "Id";
            cbxType.DataSource = Singleton.Instance.CategoryModel.GetCategories();


            cbxSubtype.DisplayMember = "Name";
            cbxSubtype.ValueMember = "Sub_Id";
            cbxSubtype.DataSource = Singleton.Instance.CategorySubcategoryModel.GetSubcategoriesByType((int)cbxType.SelectedIndex + 1);

            cbxLocation.ValueMember = "Id";
            cbxLocation.DisplayMember = "Name";
            cbxLocation.DataSource = Singleton.Instance.CompanyDepartmentModel.GetCompaniesWithDepartments();

            cbxUsers.ValueMember = "Id";
            cbxUsers.DisplayMember = "LastnameFirstNameUsername";
            cbxUsers.DataSource = Singleton.Instance.UserModel.GetUsers();
            //UpdateView();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtScan.Select();
            //if (Singleton.Instance.UserModel.CurrentUser == null)
            //{
            //    var result = new frmLogin().ShowDialog();
            //    if (result == DialogResult.Cancel)
            //    {
            //        Application.Exit();
            //    }
            //    UpdateView();
            //}
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !DoExit();
        }

        #region --- Click Events ---

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loginToolStripMenuItem.Text == "Login")
            {
                var frm = new frmLogin();
                var result = frm.ShowDialog();
                if (result == DialogResult.OK)
                    DoUpdateView();
            }
            else
            {
                var msg = MessageBox.Show("Are you sure you want to logout?", "Logout User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    Singleton.Instance.UserModel.LogoutUser();
                    DoUpdateView();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManageItem().ShowDialog();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var result = new frmManageUserInfo().ShowDialog();
            if (result == DialogResult.OK)
            {

            }
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManageUsers().ShowDialog();
        }

        private void btnPrintBarcode_Click(object sender, EventArgs e)
        {
            var br = new BarcodeGenerator();
            var barcodeImage = br.DrawBarcode(lblId.Text.ToString().PadLeft(7, '0'));
            var dlg = new frmPrinter(barcodeImage);
            dlg.ShowDialog();
        }


        #endregion

        private void lvMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMain.SelectedItems.Count == 0)
                return;

            var selected = lvMain.SelectedItems[0];
            var id = Convert.ToInt32(selected.SubItems[1].Text);
            _selectedItem = Singleton.Instance.ItemModel.GetItem(id);


            DoUpdateItemDetails();

        }

        #region --- Methods --- 
        private bool DoExit()
        {
            var msg = MessageBox.Show("Are you sure you want to quit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
        private void DoUpdateView()
        {
            var itms = Singleton.Instance.ItemModel.GetItems();

            #region --- FILTER LOGIC ---

            if (!chkShowAllStatus.Checked)
                itms = itms.Where(h => h.Status == (ItemStatus)cbxStatus.SelectedItem).ToList();
            if (!chkShowAllType.Checked)
                itms = itms.Where(h => h.TypeId == Convert.ToInt32(cbxType.SelectedIndex + 1)).ToList();
            if (!chkShowAllSubType.Checked)
                itms = itms.Where(h => h.SubTypeId == Convert.ToInt32(cbxSubtype.SelectedValue)).ToList();

            if (!chkShowAllLocation.Checked)
            {
                var departmentId = (int)cbxLocation.SelectedValue;
                var usersIds = Singleton.Instance.UserModel.GetUsersByDepartmentId(departmentId).Select(h => h.Id).ToList(); ;

                itms = (from i in itms
                        where usersIds.Contains(i.CurrentOwner)
                        select i).ToList();
            }

            #endregion

            lvMain.LoadData(itms);

            tssUsername.Text = string.Format("Current User [{0}]", Singleton.Instance.UserModel.CurrentUser == null ? "" :
                Singleton.Instance.UserModel.CurrentUser.Username);

            loginToolStripMenuItem.Text = Singleton.Instance.UserModel.CurrentUser == null ? "Login" : "Logout";

            if (Singleton.Instance.UserModel.CurrentUser == null)
            {
                new frmLogin().ShowDialog();
            }
        }
        #endregion

        private void UpdateView(object sender, EventArgs e)
        {
            DoUpdateView();

            cbxSubtype.DisplayMember = "Name";
            cbxSubtype.ValueMember = "Sub_Id";
            cbxSubtype.DataSource = Singleton.Instance.CategorySubcategoryModel.GetSubcategoriesByType((int)cbxType.SelectedIndex + 1);

        }

        private void DoUpdateItemDetails()
        {

            var item = Singleton.Instance.ItemModel.GetItem(_selectedItem.Id);

            if (item != null)
            {
                lblId.Text = item.Id.ToString();
                lblAssetTag.Text = item.AssetTag;
                lblName.Text = item.Name;
                lblDescription.Text = item.Description;

                lblType.Text = item.Type;
                lblSubType.Text = item.SubType;

                lblBrand.Text = item.Brand;
                lblModel.Text = item.Model;
                lblSerial.Text = item.Serial;

                lblStatus.Text = item.Status.ToString();
                lblOwner.Text = item.CurrentOwnerName.ToString();
                lblLastUpdate.Text = item.LastUpdatedDate.ToString();

                lblDatePurchase.Text = item.PurchaseDate.ToShortDateString();
                lblAmount.Text = item.PurchasePrice.ToString("n2");
                lblLifeSpan.Text = item.LifeSpan.ToString();
                lblCurrentValue.Text = item.Currentvalue.ToString("n2");

                btnPrintBarcode.Enabled = true;

                btnCheckout.Enabled = item.Status == ItemStatus.Available || item.Status == ItemStatus.Reserved;
                btnReserve.Enabled = item.Status == ItemStatus.Available;
                btnCheckin.Enabled = item.Status == ItemStatus.Borrowed || item.Status == ItemStatus.Reserved;
            }
        }

        private void UpdateItemStatus(ItemStatus status, int userId)
        {
            if (_selectedItem != null)
            {
                ItemModel itm = new ItemModel();
                Singleton.Instance.ItemModel.UpdateItemStatus(_selectedItem.Id, userId, status);

                DoUpdateView();
                DoUpdateItemDetails();
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            UpdateItemStatus(ItemStatus.Borrowed, (int)cbxUsers.SelectedValue);
            Singleton.Instance.TransactionModel.InsertLog(Singleton.Instance.UserModel.CurrentUser.Id, (int)cbxUsers.SelectedValue, ViewModel.TransactionType.BorrowItem, "", _selectedItem.Id);
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            UpdateItemStatus(ItemStatus.Available, 0);
            Singleton.Instance.TransactionModel.InsertLog(Singleton.Instance.UserModel.CurrentUser.Id, 0, ViewModel.TransactionType.ReturnItem, "", _selectedItem.Id);
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            UpdateItemStatus(ItemStatus.Reserved, (int)cbxUsers.SelectedValue);
            Singleton.Instance.TransactionModel.InsertLog(Singleton.Instance.UserModel.CurrentUser.Id, (int)cbxUsers.SelectedValue, ViewModel.TransactionType.ReserveItem, "", _selectedItem.Id);
        }

        private void btnShowLogs_Click(object sender, EventArgs e)
        {

        }

        private void lvMain_DoubleClick(object sender, EventArgs e)
        {
            var selected = lvMain.SelectedItems[0];
            var id = Convert.ToInt32(selected.SubItems[1].Text);


            var dlg = new frmManageItem(id, false);
            dlg.ShowDialog();
        }

        private void manageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmManageRequest().ShowDialog();
        }

        private void addItemTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManageItemType().ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtScan_TextChanged(object sender, EventArgs e)
        {

            var itms = Singleton.Instance.ItemModel.GetItems();
            var val = txtScan.Text;
            

            if (txtScan.Text.Length == 8)
            {

                if (txtScan.Text != null)
                {
                    if (itms.Count >= 0)
                    {
                        val = val.Substring(0, val.Length - 1);
                        itms = itms.Where(h => h.Id == Convert.ToInt32(val)).ToList();
                        lvMain.LoadData(itms);
                        if (lvMain.Items.Count > 0)
                        {
                            lvMain.Items[0].Selected = true;
                            lvMain.Select();
      
                            //if (lvMain.Items[0].Selected == false)
                            //{
                       

                            //}           

                        }

                    }
                    if (txtScan.Text.Length == 8 && !itms.Any())
                    {
                        MessageBox.Show("Item/s is not found!");

                    }
                    if (txtScan.Text.Length == 8)
                    {
                        txtScan.SelectAll();
                    }

                }
                

            }


        }

        private void txtScan_Click(object sender, EventArgs e)
        {
            txtScan.Clear();
            DoUpdateView();
        }

        private void cbxSubtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkShowAllSubType.Checked == false) {
                var itms = Singleton.Instance.ItemModel.GetItems();
                itms = itms.Where(h => h.SubTypeId == Convert.ToInt32(cbxSubtype.SelectedValue)).ToList();
                lvMain.LoadData(itms);
                        }
            }
            

        private void chkShowAllSubType_CheckedChanged(object sender, EventArgs e)
        {
            DoUpdateView();
        }

        private void lvMain_Click(object sender, EventArgs e)
        {
           // DoUpdateView();
        }
    }

}



