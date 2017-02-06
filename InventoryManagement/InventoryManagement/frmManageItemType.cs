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


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Create
            if (!isUpdate)
            {
               var retVal = Singleton.Instance.CategoryModel.CreateType(txtType.Text);

                if(retVal > 0)
                {
                    MessageBox.Show("Successfully save");
                }

            }
            else
            {
                var retVal = Singleton.Instance.CategoryModel.Update(id, txtType.Text);

                if (retVal > 0)
                {
                    MessageBox.Show("Successfully save");
                }
            }


            //    if (isUpdate)
            //    {
            //        if ()
            //        {
            //            MessageBox.Show("User successfully created!");
            //            this.DialogResult = DialogResult.OK;
            //            this.Close();
            //        }
            //    }
            //    else
            //    {
            //        if (Singleton.Instance.CategorySubcategoryModel.UpdateItem(4, txtType.Text))
            //        {
            //            MessageBox.Show("User successfully created!");
            //            this.DialogResult = DialogResult.OK;
            //            this.Close();
            //        }
            //    }
            //}
            //var type = txtType.Text;
            //Singleton.Instance.CategorySubcategoryModel.CreateType(type);
            MessageBox.Show("User successfully created!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
