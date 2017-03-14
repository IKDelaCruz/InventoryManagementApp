using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Utils
{
    public class ImageCon
    {
        //convert bytearray to image
        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null)
                return null;

            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
          
        }
        //another easy way to convert image to bytearray
        public static byte[] imgToByteConverter(Image inImg)
        {
            ImageConverter imgCon = new ImageConverter();
            return (byte[])imgCon.ConvertTo(inImg, typeof(byte[]));
        }
        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }
    }
}
