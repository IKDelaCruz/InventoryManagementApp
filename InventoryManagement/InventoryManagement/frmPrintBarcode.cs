using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class frmPrintBarcode : Form
    {
        public frmPrintBarcode(Image img, string name, string assetTag)
        {
            InitializeComponent();

            pbBarcode.Image = img;
            lblDatePrinted.Text = assetTag + " | " + name + " | " + DateTime.Now.ToShortDateString();
    
        }

        private void btnPrintBarcode_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            // Print the document.
            pd.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pbBarcode.Image, 0, 0);
                      
            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Center;
            RectangleF drawRect = new RectangleF(0, 110, pbBarcode.Image.Width, 50);
          
            e.Graphics.DrawString(lblDatePrinted.Text, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, drawRect, drawFormat);

        }
    }


    }

