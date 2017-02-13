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
    public partial class frmEndUser : frmBase
    {
        public frmEndUser()
        {
            InitializeComponent();

            LoadComboBox();

            var user = Singleton.Instance.UserModel.CurrentUser.Id;
            cbxUsers.SelectedValue = user;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var request = new RequestViewModel();
            request.RequestedDate = DateTime.Now;
            request.RequestType = (RequestType)cbxRequestType.SelectedItem;
            request.RequestedStatus = RequestStatus.New;
            request.RequestItemPrimaryType = (int)cbxType.SelectedIndex + 1;
            request.RequestSecondaryItemType = (int)cbxSubType.SelectedValue;
            request.Subtype = cbxSubType.Text;
            request.NeededDate = dtpNeededDate.Value;
            request.UserId = (int)cbxUsers.SelectedValue;
            request.Remarks = txtRemarks.Text.ToString();

            var result = Singleton.Instance.RequestModel.CreateNewRequest(request);
           

            if (result > 0)
            {
                MessageBox.Show("Request successfully submitted!");
                ClearDisplay();
            }
        }
        private void ClearDisplay()
        {
            cbxRequestType.SelectedIndex = 0;
            cbxType.SelectedIndex = 0;
            cbxSubType.SelectedIndex = 0;
            dtpNeededDate.Value = DateTime.Now;
            cbxUsers.SelectedIndex = 0;
            txtRemarks.Text = "";
        }
        private void frmEndUser_Load(object sender, EventArgs e)
        {

            var user = Singleton.Instance.UserModel.CurrentUser.Id;
            cbxUsers.SelectedValue = user;

        }
        private void LoadComboBox()
        {
            cbxRequestType.DataSource = Enum.GetValues(typeof(RequestType));

            cbxType.DisplayMember = "Name";
            cbxType.ValueMember = "Id";
            cbxType.DataSource = Singleton.Instance.CategoryModel.GetCategories();


            cbxSubType.DisplayMember = "Name";
            cbxSubType.ValueMember = "Sub_Id";
            cbxSubType.DataSource = Singleton.Instance.CategorySubcategoryModel.GetSubcategoriesByType((int)cbxType.SelectedIndex + 1);

            cbxUsers.ValueMember = "Id";
            cbxUsers.DisplayMember = "LastnameFirstNameUsername";

            cbxUsers.DataSource = Singleton.Instance.UserModel.GetUsers();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DisplayRequest()
        {
            var user = Singleton.Instance.UserModel.CurrentUser;
            var requests = Singleton.Instance.RequestModel.GetRequestByUserId(user.Id);
            lbRequest.Items.Clear();

            foreach(RequestViewModel rv in requests)
            {
                lbRequest.Items.Add("REQ#" + rv.Id.ToString().PadLeft(7, '0'));
            }
        }

        private void tbMain_TabIndexChanged(object sender, EventArgs e)
        {
        }

        private void tbMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbMain.SelectedIndex == 1)
                DisplayRequest();
        }

        private void lbRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = lbRequest.SelectedItem.ToString();
            var id = Convert.ToInt32(item.Replace("REQ#", ""));

            var requestInfo = Singleton.Instance.RequestModel.GetRequestById(id);

            if(requestInfo != null)
            {
                lblRequestType.Text = requestInfo.RequestType.ToString();
                lblItemType.Text = requestInfo.Subtype.ToString();
                lblDateNeeded.Text = requestInfo.NeededDate.ToString();
                lblDateRequested.Text = requestInfo.RequestedDate.ToString();
                lblUserRemarks.Text = requestInfo.Remarks;
                lblStatus.Text = requestInfo.RequestedStatus.ToString();
                lblHandedBy.Text = requestInfo.ProcessedById != 0 ? Singleton.Instance.UserModel.GetUsersById(requestInfo.ProcessedById).LastnameFirstName : "System";
                lblAdminRemarks.Text = requestInfo.AdminRemarks;

            }
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxSubType.DisplayMember = "Name";
            cbxSubType.ValueMember = "Sub_Id";
            cbxSubType.DataSource = Singleton.Instance.CategorySubcategoryModel.GetSubcategoriesByType((int)cbxType.SelectedIndex + 1);
        }
    }
}
