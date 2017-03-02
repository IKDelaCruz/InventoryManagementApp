using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static InventoryManagement.Model.ItemSubTypeModel;
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
            if (!isUpdate)
            {
                var retVal = Singleton.Instance.ItemTypeModel.CreateType(txtType.Text);


                if (retVal.Success)
                {
                    MessageBox.Show("Successfully saved");
                }
                else
                {
                    MessageBox.Show(retVal.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void frmManageItemType_Load(object sender, EventArgs e)
        {
            FillCombobox();
        }

        private void FillCombobox()
        {

            cbxType.DisplayMember = "Name";
            cbxType.ValueMember = "Id";
            cbxType.DataSource = Singleton.Instance.ItemTypeModel.GetTypes();

            cbxSubtype.DisplayMember = "Name";
            cbxSubtype.ValueMember = "Sub_Id";
            cbxSubtype.DataSource = Singleton.Instance.ItemSubTypeModel.GetSubTypes();

            cbxSubtypeOS.DisplayMember = "Name";
            cbxSubtypeOS.ValueMember = "Sub_Id";
            cbxSubtypeOS.DataSource = Singleton.Instance.ItemSubTypeModel.GetSubTypes();

        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            if (!isUpdate)
            {
                var result = Singleton.Instance.ItemSubTypeModel.CreateSubItemType((Convert.ToInt32(cbxType.SelectedValue)), txtSubtype.Text);

                if (result.Success)
                {
                    MessageBox.Show("Successfully saved");
                }
                else
                {
                    MessageBox.Show(result.Message);
                }


            }



        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            FillCombobox();
        }



        private void SaveBrand_Click(object sender, EventArgs e)
        {
            var result = Singleton.Instance.BrandModel.GetBrandName(Convert.ToInt32(cbxSubtype.SelectedValue), txtNewBrand.Text);

            if (result != null)
            {
                MessageBox.Show("Brand name already exists!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (!isUpdate)
                {
                    var retval = Singleton.Instance.BrandModel.CreateNewBrand(Convert.ToInt32(cbxSubtype.SelectedValue), txtNewBrand.Text);

                    if (retval.Success)
                    {
                        MessageBox.Show("Successfully saved");

                    }

                }

            }



            //else
            //{
            //    var retBrand = Singleton.Instance.BrandModel.Update(id, txtNewBrand.Text);

            //    if (retBrand > 0)
            //    {
            //        MessageBox.Show("Successfully saved");
            //    }
            //}

        }

        private void btnCancel3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveOs_Click(object sender, EventArgs e)
        {


            var result = Singleton.Instance.ItemModel.GetOSname(Convert.ToInt32(cbxSubtypeOS.SelectedValue), txtOs.Text);

            if (result != null)
            {
                MessageBox.Show("OS name already exists!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (!isUpdate)
                {
                    var retOs = Singleton.Instance.ItemModel.createOS(Convert.ToInt32(cbxSubtypeOS.SelectedValue), txtOs.Text);

                    if (retOs > 0)
                    {
                        MessageBox.Show("Successfully saved");

                    }

                }

            }

            //else
            //{
            //    var retOs = Singleton.Instance.ItemModel.UpdateOs(id, txtOs.Text);

            //    if (retOs > 0)
            //    {
            //        MessageBox.Show("Successfully saved");
            //    }
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
