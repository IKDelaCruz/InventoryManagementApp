using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
   public class frmBase : Form
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBase
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBase";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmBase_Load);
            this.ResumeLayout(false);

        }
        public int ReturnInt { get; set; }
        public bool IsInitializing { get; set; }

        private void frmBase_Load(object sender, EventArgs e)
        {

        }
    }
}
