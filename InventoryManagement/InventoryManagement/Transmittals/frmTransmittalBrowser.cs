using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using InventoryManagement.Model;
using InventoryLib.ViewModel;

namespace InventoryManagement
{
    public partial class frmTransmittalBrowser : Form
    {
        int _transmittalId = 0;
        public frmTransmittalBrowser(int tranmisttalId)
        {
            InitializeComponent();
            _transmittalId = tranmisttalId;
        }

        private void frmWebBrowser_Load(object sender, EventArgs e)
        {
            var transmittal = Singleton.Instance.TransmittalModel.GetTransmittalById(_transmittalId);

            var templateFile = Utils.Helper.GetWorkingDirectory() + @"\Report\transmittal_template.html";
            var updatedText = File.ReadAllText(templateFile);

            updatedText = updatedText.Replace("TransmittalFormNumber", _transmittalId.ToString());
            updatedText = updatedText.Replace("TransmittedToName", transmittal.TransmittedToUser);
            updatedText = updatedText.Replace("TransmittedToDept", transmittal.TransmittedToDepartment);
            updatedText = updatedText.Replace("TransmittedToDate", transmittal.TransmittedDate.ToString());
            updatedText = updatedText.Replace("PreparedByName", transmittal.PreparedBy);
            updatedText = updatedText.Replace("ApprovedByName", transmittal.ApprovedBy);
            updatedText = updatedText.Replace("ReceivedByName", transmittal.TransmittedToUser);

            var itemHtml = "";
            foreach (TransmittalItemViewModel it in transmittal.TransmittalItems)
            {
                itemHtml += HtmlGenerator.GenerateTransmittalItemsHtml(string.Format("{0} | {1} | {2}",
                    it.Type,
                    it.SubType,
                    it.Description),
                    it.AssetTag + " [ " + it.Serial + " ]", "1", "Unit");
            }
            if (transmittal.TransmittalItems.Count < 5)
            {
                for (int x = 0; x < 5 - transmittal.TransmittalItems.Count; x++)
                {
                    itemHtml += HtmlGenerator.GenerateTransmittalItemsHtml("", "", "", "");
                }
            }
            updatedText = updatedText.Replace("ItemDetailTable", itemHtml);
            var filename = "transmittal" + _transmittalId + ".html";

            File.WriteAllText(Utils.Helper.GetWorkingDirectory() + @"\Report\" + filename, updatedText);
            var filepath2 = Utils.Helper.GetWorkingDirectory() + @"\Report\" + filename;

            Uri uri = new Uri(filepath2);
            wbMain.Navigate(uri);
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
