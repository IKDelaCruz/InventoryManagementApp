using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Repository
{
    public class BaseRepository
    {
        InventoryMangementEntities Db;

        public BaseRepository()
        {
            Db = new InventoryMangementEntities();
        }

        public InventoryMangementEntities Database
        {
            get
            {
                return Db;
            }

           
        }
    }
}
