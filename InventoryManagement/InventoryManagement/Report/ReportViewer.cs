using InventoryManagement.Report.InventoryManagementData;
using InventoryManagement.Report.ReportRPT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Report
{
    public partial class ReportViewer : Form
    {
        public ReportViewer()
        {
            InitializeComponent();
        }



        private void ReportViewer_Load(object sender, EventArgs e)
        {
            var rpt = new InventoryRpt();
            rpt.SetDataSource(DataFiller.GetInventory(0));

            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
