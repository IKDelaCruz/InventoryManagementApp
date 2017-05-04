using InventoryManagement.Model;
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
    public partial class frmAttachFile : Form
    {
        PictureBox _pBid;
        bool _isImageUpload = false;
        int _itemId = 0;
        public frmAttachFile(PictureBox pbId)
        {
            InitializeComponent();
            _pBid = pbId;
            _isImageUpload = true;
        }
        public frmAttachFile(int itemId)
        {
            InitializeComponent();
            _itemId = itemId;
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();

            //openDlg.InitialDirectory = "c:\\";
            if(_isImageUpload)
            {
                openDlg.Filter = "image files |*.jpg; *.jpeg; *.png";
                openDlg.FilterIndex = 1;
            }
            else
            {
                openDlg.Filter = "doc files |*.pdf; *.doc; *.docx";
                openDlg.FilterIndex = 1;
            }
            //openFileDialog1.RestoreDirectory = true;

            var res = openDlg.ShowDialog();

            if (res == DialogResult.OK)
            {
                if(_isImageUpload)
                {
                    Image img = Image.FromFile(openDlg.FileName);
                    txtFilename.Text = openDlg.FileName;
                    var newImage = ImageCon.ScaleImage(img, 500, 500);

                    _pBid.BackgroundImage = newImage;
                }
                else
                {

                    Singleton.Instance.ItemModel.CreateAttachment(_itemId, openDlg.FileName);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }

            this.Close();
        }
    }
}
