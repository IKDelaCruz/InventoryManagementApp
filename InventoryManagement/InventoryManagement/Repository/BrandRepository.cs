using InventoryManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Repository
{
    public class BrandRepository : BaseRepository
    {
        public int CreateBrand(int id, string name)
        {
            var brand = InventoryDatabase.Brands.FirstOrDefault(b => b.name == name);
            if (brand == null)
            {
                var newBrand = new Brand() { subtype_id = id, name = name };
                InventoryDatabase.Brands.Add(newBrand);
                if (InventoryDatabase.SaveChanges() > 0)
                    return newBrand.id;

                //Unable to save 
                return -1;
            }
            //Already exist;
            return -2;

        }

        public BrandViewModel GetBrandbyName(int id, string brandName)
        {
            var brand = InventoryDatabase.Brands.FirstOrDefault(h => h.id == id && h.name == brandName);
            if (brand != null)
            {
                return new BrandViewModel
                {
                    Brand_Id = brand.id,
                    Name = brand.name,

                };
            }

            return null;
        }


        public int UpdateBrand(int id, string name)
        {
            var brand = InventoryDatabase.Brands.FirstOrDefault(b => b.subtype_id == id);

            if (brand != null)
            {
                var brandExists = InventoryDatabase.Brands.FirstOrDefault(b => b.name == name);


                //Name already exist
                if (brandExists != null)
                {
                    if (brandExists.id == id)
                    {
                        return -1;
                    }
                    return -2;
                }

                brand.name = name;
            }
            InventoryDatabase.SaveChanges();
            return 1;
        }
    }
}
