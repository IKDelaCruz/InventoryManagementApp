using InventoryLib.ViewModel;
using InventoryManagement.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.GatePass
{
    public partial class frmGatePassBrowser : Form
    {
        int _transmittalId = 0;
        public frmGatePassBrowser(int tranmisttalId)
        {
            InitializeComponent();
            _transmittalId = tranmisttalId;
        }

        private void frmGatePassBrowser_Load(object sender, EventArgs e)
        {
            var transmittal = Singleton.Instance.TransmittalModel.GetTransmittalById(_transmittalId);

            var templateFile = Utils.Helper.GetWorkingDirectory() + @"\Report\gatepass_template.html";
            var updatedText = File.ReadAllText(templateFile);

            updatedText = updatedText.Replace("GatePassNumber", _transmittalId.ToString());
            updatedText = updatedText.Replace("PropertyToName", transmittal.TransmittedToUser);
            updatedText = updatedText.Replace("TransmittedToDept", transmittal.TransmittedToDepartment);
            updatedText = updatedText.Replace("GatePassDate", transmittal.TransmittedDate.ToString());


            updatedText = updatedText.Replace("PropertyFromName", transmittal.PreparedBy);
            updatedText = updatedText.Replace("GatePassRequestedBy", transmittal.PreparedBy);
            updatedText = updatedText.Replace("GatePassNotedBy", transmittal.NotedBy);
            updatedText = updatedText.Replace("GatePassApprovedBy", transmittal.ApprovedBy);
            updatedText = updatedText.Replace("GatePassTime", "");
            updatedText = updatedText.Replace("GatePassGuardOnDuty", "");


            var itemHtml = "";
            foreach (TransmittalItemViewModel it in transmittal.TransmittalItems)
            {
                itemHtml += HtmlGenerator.GenerateGatePassItemsHtml(string.Format("{0} | {1} | {2}",
                    it.Type,
                    it.SubType,
                    it.Description),
                    it.AssetTag + " [ " + it.Serial + " ]", "1", "Unit");
            }

            if (transmittal.TransmittalItems.Count < 5)
            {
                for (int x = 0; x < 5 - transmittal.TransmittalItems.Count; x++)
                {
                    itemHtml += HtmlGenerator.GenerateGatePassItemsHtml("", "", "", "");
                }

            }
            updatedText = updatedText.Replace("ItemDetailTable", itemHtml);


            var filename = "gatepass" + _transmittalId + ".html";

            File.WriteAllText(Utils.Helper.GetWorkingDirectory() + @"\Report\" + filename, updatedText);
            var filepath2 = Utils.Helper.GetWorkingDirectory() + @"\Report\" + filename;

            Uri uri = new Uri(filepath2);
            wbMain.Navigate(uri);
        }

        private void btnPrintBarcode_Click(object sender, EventArgs e)
        {
          

        }
        private void ToggleHeaderFooter()
        {
            string keyName = @"Software\Microsoft\Internet Explorer\PageSetup";
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyName, true))
            {
                if (key != null)
                {
                    string old_footer = (string)key.GetValue("footer") ?? "";
                    string old_header = (string)key.GetValue("header") ?? "";
                    key.SetValue("footer", "");
                    key.SetValue("header", "");
                    wbMain.Print();
                    key.SetValue("footer", old_footer);
                    key.SetValue("header", old_header);
                }
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleHeaderFooter();
        }
    }
}
