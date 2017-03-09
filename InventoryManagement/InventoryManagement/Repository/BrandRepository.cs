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

            var newBrand = new brand
            {
                brand_parent_id = itemSubType,
                brand_name = brandName
            };

            InventoryDatabase.brands.Add(newBrand);

            if (InventoryDatabase.SaveChanges() > 0)
            {
                result.Success = true;
                result.Param1 = newBrand.brand_id.ToString();
            }
            return result;


        }

        public BrandViewModel GetBrandbyName(int id, string brandName)
        {
            var brand = InventoryDatabase.brands.FirstOrDefault(h => h.brand_parent_id == id && h.brand_name == brandName);
            if (brand != null)
            {
                return new BrandViewModel
                {
                    Id = brand.brand_id,
                    ParentId = brand.brand_parent_id,
                    Name = brand.brand_name,

                };
            }

            return null;
        }
        public ReturnValueRepo Delete(int id)
        {
            var result = new ReturnValueRepo();

            var brand = InventoryDatabase.brands.FirstOrDefault(b => b.brand_id == id);
            if (brand != null)
            {
                InventoryDatabase.brands.Remove(brand);
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
            var brand = InventoryDatabase.brands.FirstOrDefault(b => b.brand_parent_id == id);

            if (brand != null)
            {
                var brandExists = InventoryDatabase.brands.FirstOrDefault(b => b.brand_name == name);


                //Name already exist
                if (brandExists != null)
                {
                    if (brandExists.brand_id == id)
                    {
                        return -1;
                    }
                    return -2;
                }

                brand.brand_name = name;
            }
            InventoryDatabase.SaveChanges();
            return 1;
        }

        public List<BrandViewModel> GetBrandSummary()
        {
            var list = new List<BrandViewModel>();

            var brands = InventoryDatabase.vw_brand_summary.ToList();

            foreach (vw_brand_summary br in brands)
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

            var brands = InventoryDatabase.vw_brand_summary.Where(h => h.ItemSubTypeId == subTypeId).ToList();

            foreach (vw_brand_summary br in brands)
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
