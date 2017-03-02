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
    public partial class frmManageType : Form
    {
        int selectedId = 0;
        public frmManageType()
        {
            InitializeComponent();

            dvTypes.AutoGenerateColumns = false;
        }

        private void frmManageType_Load(object sender, EventArgs e)
        {
            LoadParentType();
        }
        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dvTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DoSetSelected();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = Model.Singleton.Instance.ItemSubTypeModel.Delete(selectedId);
            if (result.Success)
                LoadSubType();
            else
            {
                MessageBox.Show(result.Message);
            }
        }
        private void btnAddType_Click(object sender, EventArgs e)
        {
            DoAddCategory();
        }
        private void dvTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DoSetSelected();
        }
        private void dvTypes_SelectionChanged(object sender, EventArgs e)
        {
            DoSetSelected();
        }

        private void DoSetSelected()
        {
            if (dvTypes.SelectedRows.Count == 0)
                return;

            var id = Convert.ToInt32(dvTypes.SelectedRows[0].Cells[0].Value);
            selectedId = id;
        }
        private void DoAddCategory()
        {
            if (chkIsParentCateogry.Checked)
            {
                var result = Model.Singleton.Instance.ItemTypeModel.CreateType(txtName.Text);
                if (result.Success)
                    LoadParentType();
                else
                    MessageBox.Show(result.Message);
            }
            else
            {
                var parentId = Convert.ToInt32(cbxParent.SelectedValue);
                var result = Model.Singleton.Instance.ItemSubTypeModel.CreateSubItemType(parentId, txtName.Text);
                if (result.Success)
                {
                    MessageBox.Show("Item type successfully created!");
                    LoadSubType();
                }
                else
                {
                    MessageBox.Show(result.Message);
                }

            }

        }
        private void LoadParentType()
        {
            cbxParent.DisplayMember = "Name";
            cbxParent.ValueMember = "Id";
            cbxParent.DataSource = Model.Singleton.Instance.ItemTypeModel.GetTypes();


        }
        private void LoadSubType()
        {
            var filterParentId = Convert.ToInt32(cbxParent.SelectedValue);

            var subCategories = Model.Singleton.Instance.ItemSubTypeModel.GetSubTypesByType(filterParentId);
            //Id, Name, Description, Picture
            dvTypes.DataSource = null;
            dvTypes.DataSource = subCategories;

            btnImage.BackgroundImage = Model.Singleton.Instance.ItemTypeModel.GetItemTypeImage(filterParentId);
        }

        private void cbxParent_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSubType();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            SetImage();
        }
        private void SetImage()
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.InitialDirectory = "c:\\";
            dlg.Filter = "image files |*.jpg; *.jpeg; *.png";
            dlg.FilterIndex = 1;

            var result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                var filename = dlg.FileName;
                var img = Image.FromFile(filename);
                btnImage.BackgroundImage = img;
                btnImage.Text = "";

                var filterParentId = Convert.ToInt32(cbxParent.SelectedValue);

                Model.Singleton.Instance.ItemTypeModel.UpdateItemTypeImage(filterParentId, img);
            }
        }
        private void SetImageSubType()
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.InitialDirectory = "c:\\";
            dlg.Filter = "image files |*.jpg; *.jpeg; *.png";
            dlg.FilterIndex = 1;

            var result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                var filename = dlg.FileName;
                var img = Image.FromFile(filename);

                Model.Singleton.Instance.ItemSubTypeModel.UpdateItemSubTypeImage(selectedId, img);

                LoadSubType();
            }
        }
        private void btnChangeIcon_Click(object sender, EventArgs e)
        {
            SetImageSubType();
        }
    }
}
