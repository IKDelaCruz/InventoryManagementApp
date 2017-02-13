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
    public partial class frmUserLogs : Form
    {
        public frmUserLogs()
        {
            InitializeComponent();
        }

        private void frmUserLogs_Load(object sender, EventArgs e)
        {
            LoadTransactions();
        }

        private void LoadTransactions()
        {
            dvLogs.DataSource = Singleton.Instance.TransactionModel.GetTransactions();
        }
    }
}
