using InventoryManagement.Model;
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
    public partial class frmLauncher : Form
    {
        public frmLauncher()
        {
            InitializeComponent();
        }

        private void frmLauncher_Load(object sender, EventArgs e)
        {
            
        }
        private void LoadLogin()
        {
         
                var result = new frmLogin().ShowDialog();
                var dresult = new DialogResult();

                if (result == DialogResult.Cancel)
                {
                    //Application.Exit();
                }
                else
                {

                    if (Singleton.Instance.UserModel.CurrentUser.UserType == 1)
                    {
                        var main = new frmMain();
                        dresult = main.ShowDialog();
                    }
                    else
                    {
                        var user = new frmEndUser();
                        dresult = user.ShowDialog();
                    }
                    if (dresult != DialogResult.OK)
                    {
                        //Application.Exit();
                    }
                    else
                    {

                    }
                }
          
        }
        private bool DoCleanExit()
        {
            var msg = MessageBox.Show("Are you sure you want to quit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                return true;
            }
            return false;

        }
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadLogin();
        }

        private void frmLauncher_FormClosing(object sender, FormClosingEventArgs e)
        {

            e.Cancel = !DoCleanExit();
            //LoadLogin();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoadLogin();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoadLogin();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


