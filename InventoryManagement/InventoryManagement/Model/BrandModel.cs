using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagement.Model;
using InventoryManagement.ViewModel;
using InventoryManagement.Repository;

namespace InventoryManagement.Model
{
    public class BrandModel
    {
        BrandRepository bR;
        public BrandModel()
        {
            bR = new BrandRepository();
        }
        public int CreateNewBrand(int id, string name)
        {
            return bR.CreateBrand(id, name);
        }

        public BrandViewModel GetBrandName(int id, string name)
        {
            return bR.GetBrandbyName(id, name);
        }

        public int Update(int id, string name)
        {
            return bR.UpdateBrand(id, name);
        }
        
    

}
}
