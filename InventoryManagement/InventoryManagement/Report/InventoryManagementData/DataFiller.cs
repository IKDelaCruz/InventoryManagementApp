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
    public class DataFiller
    {
        public static InventoryDataSet GetInventory(int id)
        {
            var dataSet = new InventoryDataSet();


            // for Data Table
            RequestRepository db = new RequestRepository();
            foreach (var rec in db.GetListRequests())
            {
                var row = dataSet.Items.NewRow();
                row["Id"] = rec.Id;
                row["Name"] = rec.ProcessedById;
                row["Date"] = rec.ProcessDate;
                row["Status"] = rec.RequestedStatus;
                row["RequestType"] = rec.RequestType;
                row["Subtype"] = rec.Subtype;
                row["RequestedBy"] = rec.UserId;

                dataSet.Items.Rows.Add(row);
            }
            

            // for Table Adapter
            //InventoryDataSetTableAdapters.DataTable1TableAdapter tableAdapter = new InventoryDataSetTableAdapters.DataTable1TableAdapter();

            //tableAdapter.Fill(dataSet.DataTable1);

            return dataSet;
        }





    }
}
