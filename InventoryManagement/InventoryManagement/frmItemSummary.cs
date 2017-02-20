using InventoryManagement.Model;
using InventoryManagement.Utils;
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
    public partial class frmItemSummary : frmBase
    {
        bool isType = true;

        public frmItemSummary()
        {
            IsInitializing = true;

            InitializeComponent();
            ListViewExtension.LoadImageList(typeImageList, 1);
            ListViewExtension.LoadImageList(subTypeImageList,  2);

            IsInitializing = false;
        }
        private void LoadCategory()
        {
            isType = true;
            var itms = Singleton.Instance.ItemModel.GetItemTypeSummary();
            lvMain.LoadData(itms, typeImageList, true);
        }
        private void LoadSubCategory(int categoryId)
        {
            var itms = Singleton.Instance.ItemModel.GetItemSubTypeSummary(categoryId);
            lvMain.LoadData(itms, subTypeImageList,  true);
        }
        private void FrmItemSummary_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void lvMain_DoubleClick(object sender, EventArgs e)
        {
            var selected = lvMain.SelectedItems[0];
            var id = Convert.ToInt32(selected.SubItems[1].Text);

            if (isType)
            {
               

                LoadSubCategory(id);

                isType = false;
            }
            else
            {
                this.ReturnInt = id;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            LoadCategory();
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
