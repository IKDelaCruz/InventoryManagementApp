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
            request.RequestItemType = (PrimaryItemType)cbxType.SelectedItem;
            request.RequestSecondaryItemType = (SecondaryItemType)cbxSubType.SelectedItem;
            request.NeededDate = dtpNeededDate.Value;
            request.UserId = (int)cbxUsers.SelectedValue;
            request.Remarks = txtRemarks.ToString();

            
        }

        private void frmEndUser_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < 100; x++)
                lbRequest.Items.Add("REQ #" + x.ToString());

        }
        private void LoadComboBox()
        {
            cbxRequestType.DataSource = Enum.GetValues(typeof(PrimaryItemType));
            cbxSubType.DataSource = Enum.GetValues(typeof(SecondaryItemType));
            cbxType.DataSource = Enum.GetValues(typeof(RequestType));

            cbxUsers.ValueMember = "Id";
            cbxUsers.DisplayMember = "LastnameFirstNameUsername";

            cbxUsers.DataSource = Singleton.Instance.UserModel.GetUsers();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
