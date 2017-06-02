using InventoryManagement.Model;
using InventoryManagement.ViewModel;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class frmUploadItems : Form
    {
        public frmUploadItems()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog openDlg = new OpenFileDialog();

                //openDlg.InitialDirectory = "c:\\";
                openDlg.Filter = "image files |*.csv; ";
                openDlg.FilterIndex = 1;
                //openFileDialog1.RestoreDirectory = true;

                var res = openDlg.ShowDialog();

                if (res == DialogResult.OK)
                {
                    var filename = openDlg.FileName;
                    txtFilename.Text = filename;

                    SplashForm.ShowSplashScreen();

                    using (TextFieldParser parser = new TextFieldParser(filename))
                    {
                        parser.TextFieldType = FieldType.Delimited;
                        parser.SetDelimiters(",");
                        while (!parser.EndOfData)
                        {
                            //Processing row
                            string[] fields = parser.ReadFields();

                            //EMPLOYEE	PCNAME	DEPARTMENT	OFFICE	CPU	OS	HDD HDD	RAM	UPS	PRINTER	LOG-IN	OS	OFFICE IP SUBNET GATEWAY AV
                            //Create CPU
                            var email = fields[16];
                            var userId = 0;

                            if(email.IndexOf("@") != -1)
                            {
                                var addr = new MailAddress(email);
                                email = addr.User;
                                var user = Singleton.Instance.UserModel.GetUsersByUsername(email);
                                if(user != null)
                                    userId = user.Id;
                            }

                            fields[5] = (fields[5] == "") ? "Unknown" : fields[5];

                            fields[3] = (fields[3] == "") ? "MS OFFICE" : fields[3].Replace(" ", "");
                            fields[4] = (fields[4] == "") ? "Unknown" : fields[4].Replace(" ", "");
                            fields[8] = (fields[8] == "") ? "Unknown" : fields[8].Replace(" ", "");
                            fields[6] = (fields[6] == "") ? "Unknown" : fields[6].Replace(" ", "");
                            fields[7] = (fields[7] == "") ? "Unknown" : fields[7].Replace(" ", "");
                            fields[10] = (fields[10] == "") ? "Unknown" : fields[10].Replace(" ", "");
                            fields[12] = (fields[12] == "") ? "Unknown" : fields[12].Replace(" ", "");
                            fields[11] = (fields[11] == "") ? "Unknown" : fields[11].Replace(" ", "");

                            var iCPU = new ItemViewModel();
                            iCPU.Name = fields[1];
                            iCPU.OS = Singleton.Instance.ItemModel.GetOSname(fields[5]).Id;
                            iCPU.Processor = (ItemProcessors)Enum.Parse(typeof(ItemProcessors), fields[4], true);
                            iCPU.Memory = (ItemMemory)Enum.Parse(typeof(ItemMemory), fields[8], true);
                            iCPU.HDD1 = (ItemHDDCapacity)Enum.Parse(typeof(ItemHDDCapacity), fields[6], true);
                            iCPU.HDD2 = (ItemHDDCapacity)Enum.Parse(typeof(ItemHDDCapacity), fields[7], true);
                            iCPU.PrinterType = (fields[10] == "network") ? (PrinterType)Enum.Parse(typeof(PrinterType), fields[10], true) : PrinterType.Local;
                            iCPU.LoginType = (ItemLoginType)Enum.Parse(typeof(ItemLoginType), fields[11], true);
                            iCPU.TypeId = 1;
                            iCPU.SubTypeId = 1;
                            iCPU.Description = string.Format("{0}({1})",fields[0],fields[2]);
                            
                            iCPU.NetworkIP = fields[12];
                            iCPU.NetworkSubnet = fields[13];
                            iCPU.NetworkGateway = fields[14];

                            if(userId > 0)
                            {
                                iCPU.CurrentOwner = userId;
                                iCPU.Status = ItemStatus.Assigned;
                            }
                            iCPU.Status = ItemStatus.Available;

                            var result = Singleton.Instance.ItemModel.CreateNewItem(iCPU, Singleton.Instance.UserModel.CurrentUser.Id);

                            iCPU.Id = Convert.ToInt32(result.Param1);

                            //Create OS - 37
                            var iOS = new ItemViewModel();
                            iOS.Name = string.Format("{0} ({1})", fields[5], fields[1]);
                            iOS.Serial = fields[17];
                            iOS.TypeId = 5;
                            iOS.SubTypeId = 37;
                            iOS.ParentId = iCPU.Id;
                            iOS.Description = fields[0];
                            if (userId > 0)
                            {
                                iOS.CurrentOwner = userId;
                                iOS.Status = ItemStatus.Assigned;
                            }
                            iOS.Status = ItemStatus.Available;

                            result = Singleton.Instance.ItemModel.CreateNewItem(iOS, Singleton.Instance.UserModel.CurrentUser.Id);


                            //Create Office - 38
                            var iOffice = new ItemViewModel();
                            iOffice.Name = string.Format("{0} ({1})", fields[3], fields[1]);
                            iOffice.Serial = fields[18];
                            iOffice.SubTypeId = 38;
                            iOffice.TypeId = 5;
                            iOffice.Description = fields[0];

                            if (userId > 0)
                            {
                                iOffice.CurrentOwner = userId;
                                iOffice.Status = ItemStatus.Assigned;
                            }
                            iOffice.Status = ItemStatus.Available;

                            result = Singleton.Instance.ItemModel.CreateNewItem(iOffice, Singleton.Instance.UserModel.CurrentUser.Id);

                            //Symantec - 36
                            var iAV = new ItemViewModel();
                            iAV.Name = "Symantec";
                            iAV.Serial = fields[15];
                            iAV.SubTypeId = 36;
                            iAV.TypeId = 5;
                            iAV.Description = fields[0];

                            iAV.CurrentOwner = userId;
                            iAV.Status = ItemStatus.Assigned;

                            if (userId > 0)
                            {
                                iAV.CurrentOwner = userId;
                                iAV.Status = ItemStatus.Assigned;
                            }
                            iAV.Status = ItemStatus.Available;

                            result = Singleton.Instance.ItemModel.CreateNewItem(iAV, Singleton.Instance.UserModel.CurrentUser.Id);

                            //Create Printer - 39
                            if (fields[11] != "" && fields[10] != "network")
                            {
                                var iPrinter = new ItemViewModel();
                                iPrinter.Name = string.Format("{0} ({1})", "Printer", fields[1]);
                                iPrinter.Model = fields[10];
                                iPrinter.SubTypeId = 39;
                                iPrinter.TypeId = 1;
                                iPrinter.Description = "";

                                if (userId > 0)
                                {
                                    iPrinter.CurrentOwner = userId;
                                    iPrinter.Status = ItemStatus.Assigned;
                                }
                                iPrinter.Status = ItemStatus.Available;

                                result = Singleton.Instance.ItemModel.CreateNewItem(iPrinter, Singleton.Instance.UserModel.CurrentUser.Id);
                            }
                        }
                    }
                    SplashForm.CloseForm();
                    MessageBox.Show("Item upload successful!");
                }
            }
        }

        private void lnkSampleFormat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var filename = "Inventory Management Sample Format.xlsx";
            var filepath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

            System.Diagnostics.Process.Start(filepath + "\\" + filename);
        }
    }
}

