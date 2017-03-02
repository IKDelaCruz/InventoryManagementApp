using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Manage
{
    public partial class frmManageBrand : Form
    {
        int selectedId = 0;
        public frmManageBrand()
        {
            InitializeComponent();

            dvBrands.AutoGenerateColumns = false;
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSubType();
        }

        private void cbxSubType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBrands();
        }

        private void LoadParentType()
        {
            cbxType.DisplayMember = "Name";
            cbxType.ValueMember = "Id";
            cbxType.DataSource = Model.Singleton.Instance.ItemTypeModel.GetTypes();
        }
        private void LoadSubType()
        {
            var filterParentId = Convert.ToInt32(cbxType.SelectedValue);

            var subCategories = Model.Singleton.Instance.ItemSubTypeModel.GetSubTypesByType(filterParentId);
            //Id, Name, Description

            cbxSubType.DisplayMember = "Name";
            cbxSubType.ValueMember = "Id";
            cbxSubType.DataSource = subCategories;
        }

        private void frmManageBrand_Load(object sender, EventArgs e)
        {
            LoadParentType();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = Model.Singleton.Instance.BrandModel.Delete(selectedId);
            if(result.Success)
            {
                LoadBrands();
            }
            else
            {
                MessageBox.Show(result.Message + Environment.NewLine + result.Param1,"Error!");
            }
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            var filterParentId = Convert.ToInt32(cbxSubType.SelectedValue);
            var result = Model.Singleton.Instance.BrandModel.CreateNewBrand(filterParentId, txtName.Text);
            if(result.Success)
            {
                MessageBox.Show("Item successfully created!");
                LoadBrands();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void dvBrands_SelectionChanged(object sender, EventArgs e)
        {
            if(dvBrands.SelectedRows.Count == 0)
                return;

            var id = Convert.ToInt32(dvBrands.SelectedRows[0].Cells[0].Value);
            selectedId = id;

        }
        private void LoadBrands()
        {
            var filterParentId = Convert.ToInt32(cbxSubType.SelectedValue);
            var brands = Model.Singleton.Instance.BrandModel.GetBrandSummaryBySubType(filterParentId);

            dvBrands.DataSource = brands;
        }
    }
}
