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
    public partial class frmManageUserRequest : frmBase
    {
     
        public frmManageUserRequest(int itemId = 0, bool AddItem = true)
        {
            InitializeComponent();
            dvLogs.AutoGenerateColumns = false;

            cbxStatus.DataSource = Enum.GetValues(typeof(RequestStatus));

            LoadRequest();
          
        }
       
        private void LoadRequest()
        {
            var request = Singleton.Instance.RequestModel.GetRequestByStatus((RequestStatus)cbxStatus.SelectedValue);

            dvLogs.DataSource = request;
        }

      

        private void dvLogs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvLogs.SelectedRows.Count == 0)
                return;

            txtUserRemarks.Text = (dvLogs.SelectedRows[0].Cells[6].Value ?? "").ToString();
            txtAdminRemarks.Text = (dvLogs.SelectedRows[0].Cells[7].Value ?? "").ToString();
        }

        private void btnApproved_Click(object sender, EventArgs e)
        {
            if (dvLogs.SelectedRows.Count == 0)
                return;

            var user = Singleton.Instance.UserModel.CurrentUser.Id;
            var id = dvLogs.SelectedRows[0].Cells[0].Value;
            var requestedby = dvLogs.SelectedRows[0].Cells[8].Value;
            var requestType = dvLogs.SelectedRows[0].Cells[2].Value.ToString();

            if(btnApproved.Text == "Delivered")
            {
                Singleton.Instance.RequestModel.DeliverRequest(Convert.ToInt32(id), txtAdminRemarks.Text, user);
                Singleton.Instance.TransactionModel.InsertLog(Singleton.Instance.UserModel.CurrentUser.Id, (int)requestedby, ViewModel.TransactionType.DeliverRequest, "", 0);
            }
            else
            {
                Singleton.Instance.RequestModel.ApproveRequest(Convert.ToInt32(id), txtAdminRemarks.Text, user);
                Singleton.Instance.TransactionModel.InsertLog(Singleton.Instance.UserModel.CurrentUser.Id, (int)requestedby, ViewModel.TransactionType.ReserveItem, "", 0);
            }
            
            LoadRequest();
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            if (dvLogs.SelectedRows.Count == 0)
                return;

            var user = Singleton.Instance.UserModel.CurrentUser.Id;
            var id = dvLogs.SelectedRows[0].Cells[0].Value;
        
            Singleton.Instance.RequestModel.DeclineRequest(Convert.ToInt32(id), txtAdminRemarks.Text, user);
            LoadRequest();
        }

        


        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            LoadRequest();
        }

        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRequest();
            if((RequestStatus)cbxStatus.SelectedValue == RequestStatus.Approved)
            {
                btnApproved.Visible = true;
                btnDecline.Visible = false;
                txtAdminRemarks.ReadOnly = true;
                btnApproved.Text = "Delivered";
            }
            else if ((RequestStatus)cbxStatus.SelectedValue == RequestStatus.New)
            {
                btnApproved.Visible = true;
                btnDecline.Visible = true;
                btnApproved.Text = "Approve";
                txtAdminRemarks.ReadOnly = false;
            }
            else
            {
                btnApproved.Visible = false;
                btnDecline.Visible = false;
                txtAdminRemarks.ReadOnly = true;
            }
        }
    }
}
