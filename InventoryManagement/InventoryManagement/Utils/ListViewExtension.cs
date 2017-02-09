using InventoryManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Utils
{
    public static class ListViewExtension
    {
        public static void LoadData(this ListView lv, List<ItemViewModel> items)
        {
            lv.Items.Clear();

            foreach (ItemViewModel iVL in items)
            {
                var newItem = new ListViewItem(iVL.Name + " [" + iVL.Status.ToString() + "]");
                newItem.ImageIndex = Convert.ToInt32(iVL.TypeId) - 1;
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
