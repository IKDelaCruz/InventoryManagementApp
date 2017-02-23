using CrystalDecisions.Shared;
using InventoryManagement.Model;
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
            LoadSubtypes();
        }

        public void LoadSubtypes()
        {
            cbxSubType.DisplayMember = "Name";
            cbxSubType.ValueMember = "Sub_Id";
            cbxSubType.DataSource = Singleton.Instance.CategorySubcategoryModel.QueryListSub();
        }



        private void ReportViewer_Load(object sender, EventArgs e)
        {

        }

        private void IfCheckedFalse()
        {

            var rpt = new InventoryRpt();
            rpt.SetDataSource(DataFiller.GetInventory(0));

            //
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

            pfield2.Name = "subtype";
            pdiscrete2.Value = cbxSubType.Text.ToString();
            pfield2.CurrentValues.Add(pdiscrete2);
            pfields.Add(pfield2);

            //
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.ParameterFieldInfo = pfields;
            crystalReportViewer1.Refresh();

        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            IfCheckedFalse();
        }


    }
}
