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
    public partial class frmManageRequest : frmBase
    {
     
        public frmManageRequest(int itemId = 0, bool AddItem = true)
        {
            InitializeComponent();
            dvLogs.AutoGenerateColumns = false;

            LoadPendingRequest();
        }
       
        private void LoadPendingRequest()
        {
            var request = Singleton.Instance.RequestModel.GetRequestByStatus(RequestStatus.New);

            dvLogs.DataSource = request;
        }

        private void dvLogs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvLogs.SelectedRows.Count == 0)
                return;

            txtUserRemarks.Text = dvLogs.SelectedRows[0].Cells[6].Value.ToString();

        }

        private void btnApproved_Click(object sender, EventArgs e)
        {
            if (dvLogs.SelectedRows.Count == 0)
                return;

            var id = dvLogs.SelectedRows[0].Cells[0].Value;
            Singleton.Instance.RequestModel.ApproveRequest(Convert.ToInt32(id));
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            if (dvLogs.SelectedRows.Count == 0)
                return;

            var id = dvLogs.SelectedRows[0].Cells[0].Value;
            Singleton.Instance.RequestModel.DeclineRequest(Convert.ToInt32(id));
        }
    }
}
