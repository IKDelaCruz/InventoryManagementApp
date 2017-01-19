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
    public partial class frmPrinter : Form
    {
        public frmPrinter(Image img)
        {
            InitializeComponent();

            pbBarcode.Image = img;
            lblDatePrinted.Text = "Date Printed: " + DateTime.Now.ToString();
        }

        private void btnPrintBarcode_Click(object sender, EventArgs e)
        {
            //add print functionality
        }
    }
}
