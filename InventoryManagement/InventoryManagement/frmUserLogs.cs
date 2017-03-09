using InventoryManagement.ViewModel;
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
    public partial class frmUserLogs : Form
    {
        List<TransactionViewModel> _reportData;
        public frmUserLogs()
        {
            InitializeComponent();

            dvLogs.AutoGenerateColumns = false;
            _reportData = new List<TransactionViewModel>();
        }

        private void frmUserLogs_Load(object sender, EventArgs e)
        {
            LoadLogs();
        }
         private void LoadLogs()
        {
            var data = Model.Singleton.Instance.TransactionModel.GetTransactions();
            _reportData = data;
            var list = new Utils.MySortableBindingList<TransactionViewModel>(data);

            dvLogs.DataSource = list;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (ExportToCsv((List<TransactionViewModel>)_reportData))
                MessageBox.Show("Export to Excel Successful");
        }
       

        private bool ExportToCsv<T>(List<T> data)
        {
            var csv = Utils.CsvExporter.CreateCsvTextFile(data);
            var save = new SaveFileDialog();
            save.Filter = "CSV | *.csv";
            if (save.ShowDialog() != DialogResult.OK) return false;
            // Compose a string that consists of three lines.


            // Write the string to a file.
            var file = new System.IO.StreamWriter(save.FileName);
            file.WriteLine(csv);

            file.Close();

            return true;
        }
    }
}
