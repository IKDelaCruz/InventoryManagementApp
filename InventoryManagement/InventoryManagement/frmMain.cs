using BarcodeLib;
using InventoryManagement.Manage;
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

namespace InventoryManagement
{
    public partial class frmMain : frmBase
    {
        List<ItemViewModel> _selectedItem;
        public frmMain()
        {
            IsInitializing = true;

            InitializeComponent();
            fillcombo();


            IsInitializing = false;
            _selectedItem = new List<ItemViewModel>();
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


            //UpdateView();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            DoUpdateView(false, false, 1);
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
                    DoUpdateView(false, false, 1);

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
            DoAddItem();
        }
        private void DoAddItem()
        {
            var result = new frmManageItemDetails().ShowDialog();
            if (result == DialogResult.OK)
            {
                DoUpdateView(false, false, 1);
            }
        }
        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var result = new frmManageUserDetails().ShowDialog();
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
            PrintBarcode();
        }
        private void PrintBarcode()
        {
            var br = new BarcodeGenerator();

            var barcodeImage = br.DrawBarcode(lblId.Text.ToString().PadLeft(7, '0'));

            var dlg = new frmPrintBarcode(barcodeImage, lblName.Text, lblAssetTag.Text);
            dlg.ShowDialog();
        }

        #endregion

        private void lvMain_SelectedIndexChanged(object sender, EventArgs e)
        {

            ViewItemDetails();
        }
        private void ViewItemDetails()
        {
            _selectedItem.Clear();
            if (lvMain.SelectedItems.Count == 0)
                return;

            var selected = lvMain.SelectedItems;
            foreach (ListViewItem li in selected)
            {
                var id = Convert.ToInt32(li.SubItems[1].Text);
                var type = Convert.ToInt32(li.SubItems[2].Text);

                ItemStatus itemStatus = (ItemStatus)Enum.Parse(typeof(ItemStatus), li.SubItems[3].Text, true);

                _selectedItem.Add(new ItemViewModel
                {
                    Id = id,
                    TypeId = type,
                    Status = (ItemStatus)itemStatus
                });

            }
            tsSelectedItem.Text = "Selected Item: " + _selectedItem.Count();

            if (lvMain.SelectedItems.Count == 1)
                DoUpdateItemDetails();
        }

        #region --- Methods --- 

        private void DoUpdateView(bool useCache, bool rememberIndex, int orderBy, bool barcodeScanner = false)
        {


            if (IsInitializing)
                return;

            var itms = new List<ItemViewModel>();
            itms = Singleton.Instance.ItemModel.GetItems(useCache);

            if (orderBy == 1)
                itms = itms.OrderBy(h => h.Name).ToList();
            else if (orderBy == 2)
                itms = itms.OrderByDescending(h => h.Status).ToList();
            else if (orderBy == 3)
                itms = itms.OrderByDescending(h => h.CurrentOwner).ToList();
            else if (orderBy == 4)
                itms = itms.OrderBy(h => h.SubType).ToList();
            else
                itms = itms.OrderByDescending(h => h.PurchaseDate).ToList();


            #region --- FILTER LOGIC ---

            if (!chkShowAllStatus.Checked)
            {
                itms = itms.Where(h => h.Status == (ItemStatus)cbxStatus.SelectedItem).ToList();
            }
            else
            {
                itms = itms.Where(h => h.Status != (ItemStatus.Disposed)).ToList();
            }
            if (!chkShowAllType.Checked)
                itms = itms.Where(h => h.TypeId == Convert.ToInt32(cbxType.SelectedValue)).ToList();
            if (!chkShowAllSubType.Checked)
                itms = itms.Where(h => h.SubTypeId == Convert.ToInt32(cbxSubtype.SelectedValue)).ToList();
            if (!chkShowAllUser.Checked)
                itms = itms.Where(h => h.CurrentOwner == Convert.ToInt32(cbxUser.SelectedValue)).ToList();

            if (!chkShowAllLocation.Checked)
            {
                var departmentId = (int)cbxLocation.SelectedValue;
                var usersIds = Singleton.Instance.UserModel.GetUsersByDepartmentId(departmentId).Select(h => h.Id).ToList(); ;

                itms = (from i in itms
                        where usersIds.Contains(i.CurrentOwner)
                        select i).ToList();
            }

            #endregion



            imgMainImage.Images.Clear();
            var images = Singleton.Instance.ItemSubTypeModel.GetItemSubTypeImages();
            foreach (ItemSubTypeViewModel x in images)
                imgMainImage.Images.Add(x.ParentId.ToString(), x.Picture);

            int index = 0;
            if (lvMain.SelectedIndices.Count > 0)
                index = lvMain.SelectedIndices[0];

            lvMain.LoadData(itms, imgMainImage);

            if (lvMain.Items.Count > 0 && rememberIndex)
            {
                lvMain.Items[index].Selected = true;
                lvMain.Focus();
            }

            tssUsername.Text = string.Format("Current User [{0}]", Singleton.Instance.UserModel.CurrentUser == null ? "" :
                Singleton.Instance.UserModel.CurrentUser.Username);

            loginToolStripMenuItem.Text = Singleton.Instance.UserModel.CurrentUser == null ? "Login" : "Logout";

            Text = "Asset Management - V" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

        }
        #endregion

        private void UpdateView(object sender, EventArgs e)
        {
            if (!IsInitializing)
            {
                //DoUpdateView(true, false, 1);

            }
        }
        private void LoadUsers()
        {
            cbxUser.DataSource = null;
            cbxUser.DisplayMember = "LastnameFirstName";
            cbxUser.ValueMember = "Id";

            cbxUser.DataSource = Singleton.Instance.UserModel.GetUsersByDepartmentId((int)cbxLocation.SelectedValue);
            // cbxUser.SelectedIndex = 0;
        }
        private void DoUpdateItemDetails()
        {
            var item = Singleton.Instance.ItemModel.GetItem(_selectedItem[0].Id);

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
                lblOwner.Text = (item.CurrentOwnerName ?? "").ToString();
                lblLastUpdate.Text = item.LastUpdatedDate.ToString();

                lblDatePurchase.Text = item.PurchaseDate.ToShortDateString();
                lblAmount.Text = item.PurchasePrice.ToString("n2");
                lblLifeSpan.Text = item.LifeSpan.ToString();
                lblCurrentValue.Text = item.Currentvalue.ToString("n2");

                btnPrintBarcode.Enabled = true;

                tsBorrow.Visible = item.Status == (ItemStatus.Available) || (item.Status == ItemStatus.Reserved);

                tsAssign.Visible = item.Status == (ItemStatus.Available);

                tsReturn.Visible = item.Status == ItemStatus.Borrowed || item.Status == ItemStatus.Reserved || item.Status == ItemStatus.Broken || item.Status == ItemStatus.Assigned || item.Status == ItemStatus.Disposed;

                tsBroken.Visible = item.Status == ItemStatus.Available;
                tsRetire.Visible = item.Status == ItemStatus.Available;

                if (Singleton.Instance.ItemModel.GetItemImage(item.Id) != null)
                {
                    var img = Singleton.Instance.ItemModel.GetItemImage(item.Id);
                    if (img != null)
                    {
                        pbId.BackgroundImage = img;
                    }
                }
            }
        }

        private void btnShowLogs_Click(object sender, EventArgs e)
        {

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
        private void manageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmManageUserRequest().ShowDialog();
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



        private void cbxSubtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvMain_Click(object sender, EventArgs e)
        {
            //DoUpdateView();
        }

        private void processedRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
                int itemType = dlg.ReturnParentInt;
                int itemSubTypeId = dlg.ReturnInt;

                var itms = Singleton.Instance.ItemModel.GetItemsBySubType(itemSubTypeId);

                chkShowAllSubType.Checked = false;
                cbxType.SelectedValue = itemType;
                cbxSubtype.SelectedValue = itemSubTypeId;

                lvMain.LoadData(itms, imgMainImage);
            }
        }
        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxSubtype.DisplayMember = "Name";
            cbxSubtype.ValueMember = "Id";
            cbxSubtype.DataSource = Singleton.Instance.ItemSubTypeModel.GetSubTypesByType((int)cbxType.SelectedValue);

            chkShowAllType.Checked = false;
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void manageItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void depreciationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageBrandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new frmManageBrand();
            dlg.ShowDialog();
        }

        private void itemSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmItemSummaryReport().ShowDialog();
        }

        private void txtScan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DoUpdateView(false, false, 1, true);
            }
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoUpdateView(false, false, 1, false);
        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoUpdateView(false, false, 3, false);
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoUpdateView(false, false, 2, false);
        }

        private void cntxtMenuStrip_Opening(object sender, CancelEventArgs e)
        {

            tsAction.Visible = lvMain.SelectedItems.Count != 0;
            tsBarcode.Visible = lvMain.SelectedItems.Count != 0;


        }

        private void tsBorrow_Click(object sender, EventArgs e)
        {
            LaunchQuickTransaction(TransactionType.BorrowItem);
        }

        private void tsReserve_Click(object sender, EventArgs e)
        {
            LaunchQuickTransaction(TransactionType.ReserveItem);
        }

        private void tsReturn_Click(object sender, EventArgs e)
        {
            LaunchQuickTransaction(TransactionType.ReturnItem);
        }

        private void LaunchQuickTransaction(TransactionType type)
        {
            var dlg = new frmQuickTransaction(_selectedItem, type);
            var result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                DoUpdateView(false, false, 1);
            }
        }



        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintBarcode();
        }

        private void tsBroken_Click_1(object sender, EventArgs e)
        {
            LaunchQuickTransaction(TransactionType.RepairItem);
        }

        private void tsRetire_Click_1(object sender, EventArgs e)
        {
            LaunchQuickTransaction(TransactionType.DisposeItem);
        }

        private void viewDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoManageItem();
        }

        private void manageToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            new frmManageUserRequest().ShowDialog();
        }

        private void cbxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadUsers();
            chkShowAllLocation.Checked = false;
        }

        private void ownerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoUpdateView(false, false, 3, false);
        }

        private void tsAction_Click(object sender, EventArgs e)
        {

        }

        private void uploadItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Singleton.Instance.UserModel.CurrentUser.Username == "ian.delacruz")
                new frmUploadItems().ShowDialog();
        }

        private void syncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmSyncLDAPUsers().ShowDialog();
        }

        private void createNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmEndUser().ShowDialog();
        }

        private void assignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchQuickTransaction(TransactionType.AssignItem);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DoUpdateView(true, false, 1);
        }

        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkShowAllStatus.Checked = false;
        }

        private void cbxSubtype_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            chkShowAllSubType.Checked = false;
        }

        private void cbxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkShowAllUser.Checked = false;
        }

        private void transmittalFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmTransmittals().ShowDialog();
        }
        private void webToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoUpdateView(false, false, 4, false);
        }

        private void gatePassToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

}



