using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static InventoryManagement.Model.CategorySubcategoryModel;
using InventoryManagement.Model;
using InventoryManagement.ViewModel;


namespace InventoryManagement
{
    public partial class frmManageItemType : Form
    {
        bool isUpdate;

        int id;

        public frmManageItemType()
        {
            InitializeComponent();
        }


        public void ShowTypeDialog(bool create)
        {
            isUpdate = !create;
        }


        private void btnSave1_Click(object sender, EventArgs e)
        {
            //Create
            if (!isUpdate)
            {
               var retVal = Singleton.Instance.CategoryModel.CreateType(txtType.Text);

                if(retVal > 0)
                {
                    MessageBox.Show("Successfully saved");
                }

            }
            else
            {
                var retVal = Singleton.Instance.CategoryModel.Update(id, txtType.Text);

                if (retVal > 0)
                {
                    MessageBox.Show("Successfully saved");
                }
            }

            //this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void frmManageItemType_Load(object sender, EventArgs e)
        {
            FillCombobox();  
        }

        private void FillCombobox() {

            cbxType.DisplayMember = "Name";
            cbxType.ValueMember = "Id";
            cbxType.DataSource = Singleton.Instance.CategoryModel.GetCategories();

        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            if (!isUpdate)
            {
                var ret = Singleton.Instance.CategoryModel.CreateSubtype((Convert.ToInt32(cbxType.SelectedIndex + 1)), txtSubtype.Text);

                if (ret > 0)
                {
                    MessageBox.Show("Successfully saved");
                }
                
            }
            else
            {
                var ret = Singleton.Instance.CategoryModel.UpdateSubtype(id, txtSubtype.Text);

                if (ret > 0)
                {
                    MessageBox.Show("Successfully saved");
                }
            }

           // this.DialogResult = DialogResult.OK;

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            FillCombobox();
        }
    }
}
