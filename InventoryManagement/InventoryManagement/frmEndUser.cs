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
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void frmEndUser_Load(object sender, EventArgs e)
        {
            for(int x = 0; x < 100; x++)
                lbRequest.Items.Add("REQ #" + x.ToString());
           
        }
    }
}
