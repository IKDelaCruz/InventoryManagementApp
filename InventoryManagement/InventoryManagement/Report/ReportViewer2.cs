using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using InventoryManagement.Model;
using InventoryManagement.Report.InventoryManagementData;
using InventoryManagement.Report.ReportRPT;


namespace InventoryManagement.Report
{
    public partial class ReportViewer2 : Form
    {
        public ReportViewer2()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //var rpt = new DepreciationRPT();
            //rpt.SetDataSource(DataFiller2.GetInventory2(0));

            //crystalReportViewer2.ReportSource = rpt;
            //crystalReportViewer2.Refresh();

            var rpt2 = new DepreciationRPT();
            rpt2.SetDataSource(DataFiller2.GetDep(0));

            var firstDate = new DateTime();
            var secondDate = new DateTime();

            firstDate = dtpDate.Value;
            secondDate = dtpDate2.Value;

            var pfields = new ParameterFields();

            var pfield = new ParameterField();
            var pdiscrete = new ParameterDiscreteValue();

            var pfield1 = new ParameterField();
            var pdiscrete1 = new ParameterDiscreteValue();

            pfield.Name = "start_date";
            pdiscrete.Value = firstDate.ToString();
            pfield.CurrentValues.Add(pdiscrete);
            pfields.Add(pfield);

            pfield1.Name = "end_date";
            pdiscrete1.Value = secondDate.ToString();
            pfield1.CurrentValues.Add(pdiscrete1);
            pfields.Add(pfield1);


            crystalReportViewer2.ReportSource = rpt2;
            crystalReportViewer2.ParameterFieldInfo = pfields;
            crystalReportViewer2.Refresh();
        }
    }
}
