using InventoryManagement.Utils;
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
    public partial class frmItemSummaryReport : Form
    {
        List<ItemViewModel> _reportData;
        public frmItemSummaryReport()
        {
            InitializeComponent();
            dvLogs.AutoGenerateColumns = false;
            _reportData = new List<ItemViewModel>();
        }

        private void LoadItems()
        {
            var data = Model.Singleton.Instance.ItemModel.GetItems(false);
            _reportData = data;

            var list = new MySortableBindingList<ItemViewModel>(data);

            dvLogs.DataSource = list;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (ExportToCsv((List<ItemViewModel>)_reportData))
                MessageBox.Show("Export to Excel Successful");
        }


        private bool ExportToCsv<T>(List<T> data)
        {
            var csv = CsvExporter.CreateCsvTextFile(data);
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
