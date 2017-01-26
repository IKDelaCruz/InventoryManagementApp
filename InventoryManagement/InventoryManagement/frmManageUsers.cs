﻿using InventoryManagement.Model;
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
    public partial class frmManageUsers : frmBase
    {
        public frmManageUsers()
        {
            InitializeComponent();

            DisplayUsers();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new frmManageUserInfo().ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DisplayUsers()
        {
            var users = Singleton.Instance.UserModel.GetUsers();
            lvUsers.Items.Clear();

            lvUsers.LoadData(users);

         

        }
    }
}