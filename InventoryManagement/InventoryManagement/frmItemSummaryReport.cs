using InventoryManagement.Model;
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


            #region --- FILTER LOGIC ---

            if (!chkShowAllStatus.Checked)
                data = data.Where(h => h.Status == (ItemStatus)cbxStatus.SelectedItem).ToList();
            if (!chkShowAllType.Checked)
                data = data.Where(h => h.TypeId == Convert.ToInt32(cbxType.SelectedValue)).ToList();
            if (!chkShowAllSubType.Checked)
                data = data.Where(h => h.SubTypeId == Convert.ToInt32(cbxSubtype.SelectedValue)).ToList();
        

            if (!chkShowAllLocation.Checked)
            {
                var departmentId = (int)cbxLocation.SelectedValue;
                var usersIds = Singleton.Instance.UserModel.GetUsersByDepartmentId(departmentId).Select(h => h.Id).ToList(); ;

                data = (from i in data
                        where usersIds.Contains(i.CurrentOwner)
                        select i).ToList();
            }

            #endregion


            var list = new MySortableBindingList<ItemViewModel>(data);

            dvLogs.DataSource = list;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            FillCombo();

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
        private void FillCombo()
        {
            cbxStatus.DataSource = Enum.GetValues(typeof(ItemStatus));

            cbxType.DisplayMember = "Name";
            cbxType.ValueMember = "Id";
            cbxType.DataSource = Singleton.Instance.ItemTypeModel.GetTypes();

            cbxSubtype.DisplayMember = "Name";
            cbxSubtype.ValueMember = "Id";
            cbxSubtype.DataSource = Singleton.Instance.ItemSubTypeModel.GetSubTypesByType((int)cbxType.SelectedValue);

            cbxLocation.ValueMember = "Id";
            cbxLocation.DisplayMember = "Name";
            cbxLocation.DataSource = Singleton.Instance.CompanyDepartmentModel.GetCompaniesWithDepartments();
        }

        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxSubtype.DisplayMember = "Name";
            cbxSubtype.ValueMember = "Id";
            cbxSubtype.DataSource = Singleton.Instance.ItemSubTypeModel.GetSubTypesByType((int)cbxType.SelectedValue);
        }

        private void cbxSubtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void cbxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void LoadItems(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

            LoadItems();
        }
    }
}
