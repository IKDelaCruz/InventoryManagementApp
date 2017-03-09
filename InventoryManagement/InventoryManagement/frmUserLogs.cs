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
    public partial class frmUserLogs : Form
    {
        public frmUserLogs()
        {
            InitializeComponent();

            dvLogs.AutoGenerateColumns = false;
        }

        private void frmUserLogs_Load(object sender, EventArgs e)
        {
            LoadLogs();
        }
         private void LoadLogs()
        {
            dvLogs.DataSource = Model.Singleton.Instance.TransactionModel.GetTransactions();
        }
    }
}
