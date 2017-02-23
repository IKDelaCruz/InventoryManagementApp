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
using InventoryManagement.ViewModel;

namespace InventoryManagement.Report
{
    public partial class ReportViewer3 : Form
    {
        public ReportViewer3()
        {
            InitializeComponent();
           
        }


        public void LoadStat()
        {
            cbxItemStat.DataSource = Enum.GetValues(typeof(ItemStatus));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rpt3 = new ItemStatRPT();
            rpt3.SetDataSource(DataFiller3.getItem(0));

            var firstDate = new DateTime();
            var secondDate = new DateTime();

            firstDate = dtpDate.Value;
            secondDate = dtpDate2.Value;

            var pfields = new ParameterFields();

            var pfield = new ParameterField();
            var pdiscrete = new ParameterDiscreteValue();

            var pfield1 = new ParameterField();
            var pdiscrete1 = new ParameterDiscreteValue();

            var pfield2 = new ParameterField();
            var pdiscrete2 = new ParameterDiscreteValue();

            pfield.Name = "start_date";
            pdiscrete.Value = firstDate.ToString();
            pfield.CurrentValues.Add(pdiscrete);
            pfields.Add(pfield);

            pfield1.Name = "end_date";
            pdiscrete1.Value = secondDate.ToString();
            pfield1.CurrentValues.Add(pdiscrete1);
            pfields.Add(pfield1);

            pfield2.Name = "status";
            pdiscrete2.Value = cbxItemStat.Text.ToString();
            pfield2.CurrentValues.Add(pdiscrete2);
            pfields.Add(pfield2);

            //
            crystalReportViewer3.ReportSource = rpt3;
            crystalReportViewer3.ParameterFieldInfo = pfields;
            crystalReportViewer3.Refresh();

        }

        private void ReportViewer3_Load(object sender, EventArgs e)
        {
            LoadStat();
        }
    }
}
