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
       
        public static void LoadData(this ListView lv, List<ItemViewModel> items, ImageList imgList, bool summary = false)
        {
            var defaultImage = Image.FromFile(Utils.Helper.GetImageDirectory(@"\items\default.jpg"));
            
            lv.Items.Clear();
            lv.LargeImageList = imgList;
            if(summary)
                imgList.Images.Clear();
            int x = 0;
            foreach (ItemViewModel item in items)
            {
               
                var itemName = string.Format("{0} ({2})", item.Name, item.Status.ToString().Substring(0,1), item.CurrentOwnerName);
             
                imgList.Images.Add(item.Picture ?? defaultImage);
                if (summary)
                {
                  
                    itemName = item.Name + " (" + item.SummaryCount.ToString() + ")";
                }

                var newItem = new ListViewItem(itemName);


                newItem.ImageIndex = summary ? x : imgList.Images.IndexOfKey(item.SubTypeId.ToString());
                //newItem.ImageIndex = x;

                newItem.SubItems.Add(item.Id.ToString());
                newItem.SubItems.Add(item.TypeId.ToString());

                lv.Items.Add(newItem);
                x++;
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

