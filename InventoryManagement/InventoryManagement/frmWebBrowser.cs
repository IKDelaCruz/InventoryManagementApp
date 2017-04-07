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
namespace InventoryManagement
{
    public partial class frmWebBrowser : Form
    {
        public frmWebBrowser()
        {
            InitializeComponent();
        }

        private void frmWebBrowser_Load(object sender, EventArgs e)
        {
            var templateFile = Utils.Helper.GetWorkingDirectory() + @"\Report\Transmittal.html";
            var updatedText = File.ReadAllText(templateFile);
            updatedText = updatedText.Replace("#Purpose", "SAMPLE PURPOSE");

            File.WriteAllText(Utils.Helper.GetWorkingDirectory() + @"\Report\1.html", updatedText);
            var filepath2 = Utils.Helper.GetWorkingDirectory() + @"\Report\1.html";
            Uri uri = new Uri(filepath2);
            wbMain.Navigate(uri);




        }

        private void btnPrintBarcode_Click(object sender, EventArgs e)
        {
            ToggleHeaderFooter();
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
    }
}
