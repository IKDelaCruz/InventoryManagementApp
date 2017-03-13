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
            request.RequestItemPrimaryType = (int)cbxType.SelectedValue;
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
                var user = Singleton.Instance.UserModel.CurrentUser.Id;
                cbxUsers.SelectedValue = user;

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
            cbxRequestType.Items.Add(RequestType.Reserve);
            cbxRequestType.Items.Add(RequestType.Repair);
            cbxRequestType.SelectedIndex = 0;

            cbxType.DisplayMember = "Name";
            cbxType.ValueMember = "Id";
            cbxType.DataSource = Singleton.Instance.ItemTypeModel.GetTypes();


            cbxSubType.DisplayMember = "Name";
            cbxSubType.ValueMember = "Id";
            cbxSubType.DataSource = Singleton.Instance.ItemSubTypeModel.GetSubTypesByType((int)cbxType.SelectedValue);

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
            var newRequest = Singleton.Instance.RequestModel.GetRequestByUserId(user.Id).Where(h=>h.RequestedStatus == RequestStatus.New);
            var oldRequest = Singleton.Instance.RequestModel.GetRequestByUserId(user.Id).Where(h => h.RequestedStatus != RequestStatus.New);

           

            trMain.Nodes.Clear();
            var tNew = new TreeNode("New Request");
            var tOld = new TreeNode("Old Request");

            foreach (RequestViewModel rv in newRequest)
            {
                tNew.Nodes.Add(rv.Id.ToString(), rv.RequestedDate.ToString());
                //lbRequest.Items.Add("REQ#" + rv.Id.ToString().PadLeft(7, '0'));
            }

            foreach (RequestViewModel rv in oldRequest)
            {
                tOld.Nodes.Add(rv.Id.ToString(), rv.RequestedDate.ToString());
                //lbRequest.Items.Add("REQ#" + rv.Id.ToString().PadLeft(7, '0'));
            }
            trMain.Nodes.Add(tNew);
            trMain.Nodes.Add(tOld);

            trMain.ExpandAll();
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
            UpdateInfo();

        }
        private void UpdateInfo()
        {
            if (trMain.SelectedNode == null)
                return;
            if (trMain.SelectedNode.Name == "")
                return;

            var item = trMain.SelectedNode.Name;
            var id = Convert.ToInt32(item);

            var requestInfo = Singleton.Instance.RequestModel.GetRequestById(id);

            if (requestInfo != null)
            {
                txtRequestType.Text = requestInfo.RequestType.ToString();
                txtItemType.Text = requestInfo.Subtype.ToString();
                txtDateNeeded.Text = requestInfo.NeededDate.ToString();
                txtDateRequested.Text = requestInfo.RequestedDate.ToString();
                txtUserRemarks.Text = requestInfo.Remarks;
                txtRequestStatus.Text = requestInfo.RequestedStatus.ToString();
                txtRequestHandledBy.Text = requestInfo.ProcessedById != 0 ? Singleton.Instance.UserModel.GetUsersById(requestInfo.ProcessedById).LastnameFirstName : "System";
                txtAdminRemarks.Text = requestInfo.AdminRemarks;

            }
        }

       

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxSubType.DisplayMember = "Name";
            cbxSubType.ValueMember = "Sub_Id";
            cbxSubType.DataSource = Singleton.Instance.ItemSubTypeModel.GetSubTypesByType((int)cbxType.SelectedValue);
        }

        private void tbMain_Click(object sender, EventArgs e)
        {

        }

      

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void frmEndUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            if(tbMain.SelectedIndex == 1)
                UpdateInfo();
        }

        private void trMain_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UpdateInfo();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}


