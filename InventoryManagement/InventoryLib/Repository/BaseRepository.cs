
using InventoryLib.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Repository
{
    public class BaseRepository
    {
        InventoryManagementEntities Db;

        public BaseRepository()
        {
            Db = new InventoryManagementEntities();
        }

        public InventoryManagementEntities InventoryDatabase
        {
            get
            {
                return Db;
            }

           
        }
    }
}
