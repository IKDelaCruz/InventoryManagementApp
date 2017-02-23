using InventoryManagement.Repository;
using InventoryManagement.Utils;
using InventoryManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Report.InventoryManagementData
{
    public class DataFiller3
    {



        



        public static ItemStatusDataSet getItem(int id)
        {
            var dataItemSet = new ItemStatusDataSet();

            // for Data Table
            ItemRepository dbase2 = new ItemRepository();
            foreach (var rec in dbase2.QueryItems())
            {
                var row = dataItemSet.ItemStatus.NewRow();
                row["Id"] = rec.Id;
                row["AssetTag"] = rec.AssetTag;
                row["Name"] = rec.Name;
                row["Description"] = rec.Description;
                row["SubtypeId"] = rec.SubTypeId;
                row["Status"] = rec.Status;
                row["LastUpdated"] = rec.LastUpdatedDate;

                dataItemSet.ItemStatus.Rows.Add(row);

                
            }
            return dataItemSet;

        }


    }

}
