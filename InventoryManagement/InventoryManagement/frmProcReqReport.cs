using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using InventoryManagement.Repository;
using InventoryManagement.Report;




namespace InventoryManagement
{
    public partial class frmProcReqReport : Form
    {
        public frmProcReqReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalReport1 crystalReport = new CrystalReport1();

            InventoryMangementDataSet req = GetData();
            crystalReport.SetDataSource(req);
            this.crystalReportViewer1.ReportSource = crystalReport;
            this.crystalReportViewer1.RefreshReport();
        }

        private void frmProcReqReport_Load(object sender, EventArgs e)
        {
   

        }


        private InventoryMangementDataSet GetData()
        {
            string constr = @"Data Source=DESKTOP-5NQKEP2\SQLEXPRESS;Initial Catalog=InventoryMangement;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from[Request]"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (InventoryMangementDataSet req = new InventoryMangementDataSet())
                        {
                            sda.Fill(req,"DataTable1");
                            return req;
                        }
                    }
                }
            }
        }

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
} 
        

    

