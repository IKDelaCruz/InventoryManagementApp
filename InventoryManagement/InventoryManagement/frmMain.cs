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
using InventoryManagement.Report;
using InventoryManagement.Manage;

namespace InventoryManagement
{
    public partial class frmMain : frmBase
    {
        ItemViewModel _selectedItem;
        public frmMain()
        {
            IsInitializing = true;

            InitializeComponent();
            fillcombo();
            ListViewExtension.LoadImageList(imgMainImage, 2);

            IsInitializing = false;
        }

        private void fillcombo()
        {

            cbxStatus.DataSource = Enum.GetValues(typeof(ItemStatus));

            cbxType.DisplayMember = "Name";
            cbxType.ValueMember = "Id";
            cbxType.DataSource = Singleton.Instance.ItemTypeModel.GetTypes();

            cbxSubtype.DisplayMember = "Name";
            cbxSubtype.ValueMember = "Id";
            cbxSubtype.DataSource = Singleton.Instance.ItemSubTypeModel.GetSubTypesByType((int)cbxType.SelectedValue);

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
            DoUpdateView(false);
            ShowSummary();

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }



        #region --- Click Events ---

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loginToolStripMenuItem.Text == "Login")
            {
                var frm = new frmLogin();
                var result = frm.ShowDialog();
                if (result == DialogResult.OK)
                    DoUpdateView(false);

            }
            else
            {
                var msg = MessageBox.Show("Are you sure you want to logout?", "Logout User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    Singleton.Instance.UserModel.LogoutUser();
                    this.Close();

                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
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

        private void DoUpdateView(bool useCache)
        {
            if (IsInitializing)
                return;

            var itms = Singleton.Instance.ItemModel.GetItems(useCache);

            #region --- FILTER LOGIC ---

            if (!chkShowAllStatus.Checked)
                itms = itms.Where(h => h.Status == (ItemStatus)cbxStatus.SelectedItem).ToList();
            if (!chkShowAllType.Checked)
                itms = itms.Where(h => h.TypeId == Convert.ToInt32(cbxType.SelectedValue)).ToList();
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

            var images = Singleton.Instance.ItemSubTypeModel.GetItemSubTypeImages();
            foreach (ItemSubTypeViewModel x in images)
                imgMainImage.Images.Add(x.Id.ToString(), x.Picture);

            lvMain.LoadData(itms, imgMainImage);

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
            if(!IsInitializing)
                DoUpdateView(true);
        }

        private void DoUpdateItemDetails()
        {
            var item = _selectedItem;
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

                DoUpdateView(false);
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
            new frmManageType().ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtScan_TextChanged(object sender, EventArgs e)
        {




        }

        private void txtScan_Click(object sender, EventArgs e)
        {
            txtScan.Clear();

        }

        private void cbxSubtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void chkShowAllSubType_CheckedChanged(object sender, EventArgs e)
        {
            DoUpdateView(true);
        }

        private void lvMain_Click(object sender, EventArgs e)
        {
            //DoUpdateView();
        }

        private void processedRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReportViewer().ShowDialog();
        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmUserLogs().ShowDialog();
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSummary();
        }
        private void ShowSummary()
        {
            var dlg = new frmItemSummary();
            var result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                int itemSubTypeId = dlg.ReturnInt;

                var itms = Singleton.Instance.ItemModel.GetItemsBySubType(itemSubTypeId);
                lvMain.LoadData(itms, imgMainImage);
            }
        }
        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxSubtype.DisplayMember = "Name";
            cbxSubtype.ValueMember = "Sub_Id";
            cbxSubtype.DataSource = Singleton.Instance.ItemSubTypeModel.GetSubTypesByType((int)cbxType.SelectedValue);
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void manageItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void depreciationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReportViewer2().ShowDialog();
        }

        private void borrowedReservedBrokenItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReportViewer3().ShowDialog();
        }

        private void manageBrandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new frmManageBrand();
            dlg.ShowDialog();
        }
    }

}



