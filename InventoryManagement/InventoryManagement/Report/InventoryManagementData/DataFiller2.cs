using System;
using InventoryManagement.Repository;
using InventoryManagement.Utils;
using InventoryManagement.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Report.InventoryManagementData
{
    public class DataFiller2
    {
        public static DepreciationDataSet GetDep(int id)
        {
            var depSet = new DepreciationDataSet();

            DepreciationDataSetTableAdapters.DataTable2TableAdapter tableAdapter2 = new DepreciationDataSetTableAdapters.DataTable2TableAdapter();

            tableAdapter2.Fill(depSet.DataTable2);

            return depSet;
        }

    }
}
