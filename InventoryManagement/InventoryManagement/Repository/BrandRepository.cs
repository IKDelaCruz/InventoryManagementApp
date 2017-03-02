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
        public ReturnValueRepo CreateBrand(int itemSubType, string brandName)
        {
            var result = new
                ReturnValueRepo();

            var newBrand = new Brand
            {
                subtype_id = itemSubType,
                name = brandName
            };

            InventoryDatabase.Brands.Add(newBrand);

            if (InventoryDatabase.SaveChanges() > 0)
            {
                result.Success = true;
                result.Param1 = newBrand.id.ToString();
            }
            return result;


        }

        public BrandViewModel GetBrandbyName(int id, string brandName)
        {
            var brand = InventoryDatabase.Brands.FirstOrDefault(h => h.subtype_id == id && h.name == brandName);
            if (brand != null)
            {
                return new BrandViewModel
                {
                    Id = brand.id,
                    ParentId = brand.subtype_id,
                    Name = brand.name,

                };
            }

            return null;
        }
        public ReturnValueRepo Delete(int id)
        {
            var result = new ReturnValueRepo();

            var brand = InventoryDatabase.Brands.FirstOrDefault(b => b.id == id);
            if (brand != null)
            {
                InventoryDatabase.Brands.Remove(brand);
                try
                {
                    result.Success = (InventoryDatabase.SaveChanges() > 0);
                }
                catch(Exception ex)
                {
                    result.Message = ex.Message;
                    result.Param1 = ex.InnerException.Message;
                }
            }
            else
            {
                result.Message = "Does not exist";
            }
            return result;
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

        public List<BrandViewModel> GetBrandSummary()
        {
            var list = new List<BrandViewModel>();

            var brands = InventoryDatabase.vwBrandSummaries.ToList();

            foreach (vwBrandSummary br in brands)
            {
                list.Add(new ViewModel.BrandViewModel
                {
                    Id = br.BrandId,
                    Count = br.ItemCount ?? 0,
                    ParentId = br.ItemSubTypeId ?? 0,
                    Name = br.BrandName
                });
            }

            return list;
        }

        public List<BrandViewModel> GetBrandSummaryBySubType(int subTypeId)
        {
            var list = new List<BrandViewModel>();

            var brands = InventoryDatabase.vwBrandSummaries.Where(h => h.ItemSubTypeId == subTypeId).ToList();

            foreach (vwBrandSummary br in brands)
            {
                list.Add(new ViewModel.BrandViewModel
                {
                    Id = br.BrandId,
                    Count = br.ItemCount ?? 0,
                    ParentId = br.ItemSubTypeId ?? 0,
                    Name = br.BrandName
                });
            }

            return list;
        }
    }
}
