using InventoryManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Utils
{
    public static class ListViewExtension
    {
        private static bool HasImageExtension(this string source)
        {
            return (source.EndsWith(".png") || source.EndsWith(".jpg"));
        }
        public static void LoadImageList(ImageList iml, int type)
        {
            
            var dir = "";
            if (type == 1)
            {
                dir = Helper.GetImageDirectory(@"\icons\type");
            }
            else
            {
                dir = Helper.GetImageDirectory(@"\icons\subtype");
            }
            string[] fileEntries = Directory.GetFiles(dir);

            foreach (string fileName in fileEntries)
            {
                if (HasImageExtension(fileName))
                    iml.Images.Add(Path.GetFileName(fileName), Image.FromFile(fileName));
            }


        }
        public static void LoadData(this ListView lv, List<ItemViewModel> items, ImageList imgList, bool summary = false)
        {
            lv.Items.Clear();
            lv.LargeImageList = imgList;

            foreach (ItemViewModel iVL in items)
            {
                var itemName = iVL.Name + " [" + iVL.Status.ToString() + "]";

                if (summary)
                {
                    itemName = iVL.Name + " (" + iVL.SummaryCount.ToString() + ")";
                }

                var newItem = new ListViewItem(itemName);


                newItem.ImageIndex = lv.LargeImageList.Images.IndexOfKey(iVL.SubTypeId + ".png");

                newItem.SubItems.Add(iVL.Id.ToString());
                newItem.SubItems.Add(iVL.TypeId.ToString());

                lv.Items.Add(newItem);
            }
        }
        public static void LoadData(this ListView lv, List<UserViewModel> items)
        {
            lv.Items.Clear();

            foreach (UserViewModel iVL in items)
            {
                var newItem = new ListViewItem(iVL.Lastname + ", " + iVL.Firstname);
                newItem.ImageIndex = Convert.ToInt32(iVL.UserType) - 1;
                newItem.SubItems.Add(iVL.Id.ToString());
                newItem.SubItems.Add(iVL.Username.ToString());
                lv.Items.Add(newItem);
            }
        }
    }
}
