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
            lv.BeginUpdate();
            lv.ListViewItemSorter = null;

            var defaultImage = Image.FromFile(Utils.Helper.GetImageDirectory(@"\items\default.jpg"));
            var tempListView = new List<ListViewItem>();
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
                newItem.SubItems.Add(item.Status.ToString());
                newItem.SubItems.Add(item.BorrowDate.DateOnly());
                newItem.SubItems.Add(item.ExpectedReturnDate.DateOnly());
                if (!summary)
                {
                    if (item.Status == ItemStatus.Available)
                        newItem.ForeColor = Color.Green;
                    else if (item.Status == ItemStatus.Borrowed || item.Status == ItemStatus.Broken)
                        newItem.ForeColor = Color.Red;
                    else if (item.Status == ItemStatus.Reserved )
                        newItem.ForeColor = Color.Blue;
                    else if (item.Status == ItemStatus.Assigned)
                        newItem.ForeColor = Color.Brown;
                    else
                        newItem.ForeColor = Color.Gray;
                }


                //lv.Items.Add(newItem);
                tempListView.Add(newItem);
                x++;
                
            }
            lv.Items.AddRange(tempListView.ToArray());
            lv.EndUpdate();
        }
        public static void LoadData(this ListView lv, List<UserViewModel> items)
        {
            lv.Items.Clear();
            lv.BeginUpdate();
            foreach (UserViewModel iVL in items)
            {
                var newItem = new ListViewItem(iVL.Lastname + ", " + iVL.Firstname);
                newItem.ImageIndex = Convert.ToInt32(iVL.UserType) - 1;
                newItem.SubItems.Add(iVL.Id.ToString());
                newItem.SubItems.Add(iVL.Username.ToString());
                lv.Items.Add(newItem);
            }
            lv.EndUpdate();
        }
    }
}


