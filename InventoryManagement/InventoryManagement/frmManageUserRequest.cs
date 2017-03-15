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

            LoadPendingRequest();
            LoadApproved();
            LoadDeclined();

            //Singleton.Instance.RequestModel.SendEmail();
        }
       
        private void LoadPendingRequest()
        {
            var request = Singleton.Instance.RequestModel.GetRequestByStatus(RequestStatus.New);

            dvLogs.DataSource = request;
        }

        private void LoadApproved() {
            var request = Singleton.Instance.RequestModel.GetApprovedReqs(RequestStatus.Approved);

            dvProcessed.DataSource = request;
        }

        private void LoadDeclined()
        {
            var request = Singleton.Instance.RequestModel.GetDeclinedReqs(RequestStatus.Declined);

            dvDeclined.DataSource = request;
        }

        private void dvLogs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvLogs.SelectedRows.Count == 0)
                return;

            txtUserRemarks.Text = dvLogs.SelectedRows[0].Cells[9].Value.ToString();

        }

        private void btnApproved_Click(object sender, EventArgs e)
        {
            if (dvLogs.SelectedRows.Count == 0)
                return;


            var user = Singleton.Instance.UserModel.CurrentUser.Id;

            var id = dvLogs.SelectedRows[0].Cells[0].Value;
            var subtypeId = dvLogs.SelectedRows[0].Cells[4].Value;
            var requestedby = dvLogs.SelectedRows[0].Cells[6].Value;
            var need_date = dvLogs.SelectedRows[0].Cells[8].Value.ToString();
            var reqtype = dvLogs.SelectedRows[0].Cells[2].Value.ToString();

            if (Convert.ToInt32(reqtype) == 0)
            {
                var ret = Singleton.Instance.ItemModel.UpdateItemStatusBySubtype((int)subtypeId, (int)requestedby, ItemStatus.Available);
                if (!ret)
                {
                    MessageBox.Show("Item not available!");
                }
                else
                {
                    Singleton.Instance.RequestModel.ApproveRequest(Convert.ToInt32(id), txtAdminRemarks.Text, user, Convert.ToDateTime(need_date));
                    Singleton.Instance.TransactionModel.InsertLog(Singleton.Instance.UserModel.CurrentUser.Id, (int)requestedby, ViewModel.TransactionType.ReserveItem, "", (int)id);
                }
            }
            else if(Convert.ToInt32(reqtype) == 2) {

                var ret = Singleton.Instance.ItemModel.UpdateItemStatusToBroken((int)subtypeId, (int)requestedby, ItemStatus.Broken);
                if (!ret)
                {
                    MessageBox.Show("Item does not exist!");
                }
                else
                {
                    Singleton.Instance.RequestModel.ApproveRequest(Convert.ToInt32(id), txtAdminRemarks.Text, user, Convert.ToDateTime(need_date));
                    Singleton.Instance.TransactionModel.InsertLog(Singleton.Instance.UserModel.CurrentUser.Id, (int)requestedby, ViewModel.TransactionType.ReserveItem, "", (int)id);
                }


               
            }

            LoadPendingRequest();


        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            if (dvLogs.SelectedRows.Count == 0)
                return;
            var user = Singleton.Instance.UserModel.CurrentUser.Id;
            var id = dvLogs.SelectedRows[0].Cells[0].Value;
            var need_date = dvLogs.SelectedRows[0].Cells[8].Value.ToString();
            Singleton.Instance.RequestModel.DeclineRequest(Convert.ToInt32(id), txtAdminRemarks.Text, user, Convert.ToDateTime(need_date));
            LoadPendingRequest();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            LoadApproved();
        }

        private void frmManageRequest_Load(object sender, EventArgs e)
        {
            //LoadPendingRequest();
        }

        private void tabControl1_Click_1(object sender, EventArgs e)
        {
            LoadApproved();
            LoadPendingRequest();
            LoadDeclined();

        }

        private void txtUserRemarks_TextChanged(object sender, EventArgs e)
        {

        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            LoadPendingRequest();
        }
    }
}
