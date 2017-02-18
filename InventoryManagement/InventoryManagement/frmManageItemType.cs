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
using InventoryManagement.Repository;

namespace InventoryManagement
{
    public partial class frmManageItemType : frmBase
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

            cbxSubtype.DisplayMember = "Name";
            cbxSubtype.ValueMember = "Sub_Id";
            cbxSubtype.DataSource = Singleton.Instance.CategorySubcategoryModel.GetSubcategories();

            cbxSubtypeOS.DisplayMember = "Name";
            cbxSubtypeOS.ValueMember = "Sub_Id";
            cbxSubtypeOS.DataSource = Singleton.Instance.CategorySubcategoryModel.GetSubcategories();

        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            if (!isUpdate)
            {
                var ret = Singleton.Instance.CategoryModel.CreateSubtype((Convert.ToInt32(cbxType.SelectedValue)), txtSubtype.Text);

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

   

        private void SaveBrand_Click(object sender, EventArgs e)
        {
 
            if (!isUpdate)
            {
                var retBrand = Singleton.Instance.BrandModel.CreateNewBrand(Convert.ToInt32(cbxSubtype.SelectedValue), txtNewBrand.Text);

                if (retBrand > 0)
                {
                    MessageBox.Show("Successfully saved");
                }

            }
            else
            {
                var retBrand = Singleton.Instance.BrandModel.Update(id, txtNewBrand.Text);

                if (retBrand > 0)
                {
                    MessageBox.Show("Successfully saved");
                }
            }
          
        }

        private void btnCancel3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveOs_Click(object sender, EventArgs e)
        {
            if (!isUpdate)
            {
                var retOs = Singleton.Instance.ItemModel.createOS(Convert.ToInt32(cbxSubtypeOS.SelectedValue), txtOs.Text);

                if (retOs > 0)
                {
                    MessageBox.Show("Successfully saved");
                }

            }
            else
            {
                var retOs = Singleton.Instance.ItemModel.UpdateOs(id, txtOs.Text);

                if (retOs > 0)
                {
                    MessageBox.Show("Successfully saved");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
