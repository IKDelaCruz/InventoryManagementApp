using BarcodeLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Utils
{
    public class BarcodeGenerator
    {
        public System.Drawing.Image DrawBarcode(string text)
        {
            BarcodeLib.Barcode barcode = new BarcodeLib.Barcode()
            {
                IncludeLabel = true,
                Alignment = AlignmentPositions.CENTER,
                Width = 300,
                Height = 100,
                RotateFlipType = RotateFlipType.RotateNoneFlipNone,
                BackColor = Color.White,
                ForeColor = Color.Black,

            };
            //i.ToString().PadLeft(3, '0'); 
            Image img = barcode.Encode(TYPE.EAN8, text);

            return img;
        }
    }
}
