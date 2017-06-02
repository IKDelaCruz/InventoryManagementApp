using InventoryManagement.GatePass;
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

namespace InventoryManagement
{
    public partial class frmTransmittals : Form
    {
        public frmTransmittals()
        {
            InitializeComponent();
            dvTransmittals.AutoGenerateColumns = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadTransmittals()
        {
            dvTransmittals.DataSource = Singleton.Instance.TransmittalModel.GetTransmittals();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadTransmittals();
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            var result =  new frmCreateNewTransmittal().ShowDialog();
            if(result == DialogResult.OK)
            {
                LoadTransmittals();
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var id = dvTransmittals.SelectedRows[0].Cells[0].Value;

            new frmTransmittalBrowser(Convert.ToInt32(id)).ShowDialog();
        }

        private void printGatePassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var id = dvTransmittals.SelectedRows[0].Cells[0].Value;

            new frmGatePassBrowser(Convert.ToInt32(id)).ShowDialog();
        }
    }
}
