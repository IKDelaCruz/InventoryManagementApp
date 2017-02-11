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
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
                printDocument1.OriginAtMargins = true;
                printDocument1.DocumentName = "PRINT BARCODE";

                printDialog1.Document = printDocument1;
                printDialog1.ShowDialog();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pbBarcode.Image, 0, 0);
            e.Graphics.DrawString(lblDatePrinted.Text, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, 50, 110);
        }
    }


    }

