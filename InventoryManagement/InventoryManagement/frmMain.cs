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
        public frmMain()
        {
            InitializeComponent();

            cbxStatus.DataSource = Enum.GetValues(typeof(ItemStatus));
            cbxType.DataSource = Enum.GetValues(typeof(PrimaryItemType));
            cbxSubtype.DataSource = Enum.GetValues(typeof(SecondaryItemType));

            cbxLocation.ValueMember = "Id";
            cbxLocation.DisplayMember = "Name";

            cbxLocation.DataSource = Singleton.Instance.CompanyDepartmentModel.GetCompaniesWithDepartments();
            //UpdateView();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loginToolStripMenuItem.Text == "Login")
            {
                var frm = new frmLogin();
                var result = frm.ShowDialog();
                if (result == DialogResult.OK)
                    UpdateView();
            }
            else
            {
                var msg = MessageBox.Show("Are you sure you want to logout?", "Logout User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    Singleton.Instance.UserModel.LogoutUser();
                    UpdateView();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool DoExit()
        {
            var msg = MessageBox.Show("Are you sure you want to quit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManageItem().ShowDialog();
        }
        private void UpdateView()
        {
            var itms = Singleton.Instance.ItemModel.GetItems();
            if (!chkShowAllStatus.Checked)
                itms = itms.Where(h => h.Status == (ItemStatus)cbxStatus.SelectedItem).ToList();
            if (!chkShowAllType.Checked)
                itms = itms.Where(h => h.Type == (PrimaryItemType)cbxType.SelectedItem).ToList();
            if (!chkShowAllSubType.Checked)
                itms = itms.Where(h => h.SubType == (SecondaryItemType)cbxSubtype.SelectedItem).ToList();
            if (!chkShowAllLocation.Checked)
            {
                var departmentId = (int)cbxLocation.SelectedValue;
                var usersIds = Singleton.Instance.UserModel.GetUsersByDepartmentId(departmentId).Select(h => h.Id).ToList(); ;

                itms = (from i in itms
                       where usersIds.Contains(i.CurrentOwner)
                       select i).ToList();
            }
                

            lvMain.LoadData(itms);
            tssUsername.Text = string.Format("Current User [{0}]", Singleton.Instance.UserModel.CurrentUser == null ? "" :
                Singleton.Instance.UserModel.CurrentUser.Username);

            loginToolStripMenuItem.Text = Singleton.Instance.UserModel.CurrentUser == null ? "Login" : "Logout";

            if (Singleton.Instance.UserModel.CurrentUser == null)
            {
                new frmLogin().ShowDialog();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
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

        private void lvMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMain.SelectedItems.Count == 0)
                return;

            var selected = lvMain.SelectedItems[0];
            var id = Convert.ToInt32(selected.SubItems[1].Text);
            var item = Singleton.Instance.ItemModel.GetItem(id);
            if (item != null)
            {
                lblId.Text = item.Id.ToString();
                lblAssetTag.Text = item.AssetTag;
                lblName.Text = item.Name;
                lblDescription.Text = item.Description;

                lblType.Text = item.Type.ToString();
                lblSubType.Text = item.SubType.ToString();

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
            }
        }

        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void chckShowAll_CheckedChanged(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void chkShowAllStatus_CheckedChanged(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void chkShowAllType_CheckedChanged(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void chkShowAllSubType_CheckedChanged(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void chkShowAllLocation_CheckedChanged(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void cbxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void cbxSubtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var result = new frmManageUserInfo().ShowDialog();
            if(result == DialogResult.OK)
            {

            }
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManageUsers().ShowDialog();
        }

        private void btnPrintBarcode_Click(object sender, EventArgs e)
        {
            BarcodeLib.Barcode barcode = new BarcodeLib.Barcode()
            {
                IncludeLabel = true,
                Alignment = AlignmentPositions.CENTER,
                Width = 300,
                Height = 100,
                RotateFlipType = RotateFlipType.RotateNoneFlipNone,
                BackColor = Color.White,
                ForeColor = Color.Black,
                
            };
            //i.ToString().PadLeft(3, '0'); 
            Image img = barcode.Encode(TYPE.EAN8, lblId.Text.ToString().PadLeft(7, '0'));

            var dlg = new frmPrinter(img);
            dlg.ShowDialog();
        }
    }
}
