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
                newItem.ImageIndex = Convert.ToInt32(iVL.Type) - 1;
                newItem.SubItems.Add(iVL.Id.ToString());
                newItem.SubItems.Add(iVL.Type.ToString());

                lv.Items.Add(newItem);
            }
        }
    }
}-
