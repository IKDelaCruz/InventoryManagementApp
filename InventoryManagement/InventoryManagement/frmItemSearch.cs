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
    public partial class frmItemSearch : frmBase
    {
        public frmItemSearch()
        {
            InitializeComponent();

            LoadTypeSubType();
            LoadItems();
            ReturnIntList = new List<int>();
        }
        private void LoadTypeSubType()
        {
            cbxType.DisplayMember = "Name";
            cbxType.ValueMember = "Id";
            cbxType.DataSource = Singleton.Instance.ItemTypeModel.GetTypes();

           
        }
        private void LoadSubType()
        {
            cbxSubtype.DisplayMember = "Name";
            cbxSubtype.ValueMember = "Id";
            cbxSubtype.DataSource = Singleton.Instance.ItemSubTypeModel.GetSubTypesByType((int)cbxType.SelectedValue);
        }
        private void LoadItems()
        {
            var itms = new List<ItemViewModel>();
            if (txtFilter.Text == "")
                itms = Singleton.Instance.ItemModel.GetItemsBySubType((int)cbxSubtype.SelectedValue, true);
            else
                itms = Singleton.Instance.ItemModel.GetItems(txtFilter.Text);


            imgMainImage.Images.Clear();
            var images = Singleton.Instance.ItemSubTypeModel.GetItemSubTypeImages();
            foreach (ItemSubTypeViewModel x in images)
                imgMainImage.Images.Add(x.ParentId.ToString(), x.Picture);

            int index = 0;
            if (lvItems.SelectedIndices.Count > 0)
                index = lvItems.SelectedIndices[0];

            lvItems.LoadData(itms, imgMainImage);

            if (lvItems.Items.Count > 0 && false)
            {
                lvItems.Items[index].Selected = true;
                lvItems.Focus();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSubType();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void lvItems_DoubleClick(object sender, EventArgs e)
        {
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvItems.SelectedItems)
            {
                var id = Convert.ToInt32(lvi.SubItems[1].Text);
                ReturnIntList.Add(id);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
