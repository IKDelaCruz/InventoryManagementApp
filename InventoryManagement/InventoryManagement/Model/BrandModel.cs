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
        BrandRepository brandRepository;
        public BrandModel()
        {
            brandRepository = new BrandRepository();
        }
        public ReturnValueRepo CreateNewBrand(int id, string name)
        {
            return brandRepository.CreateBrand(id, name);
        }
        public ReturnValueRepo Delete(int id)
        {
            return brandRepository.Delete(id);
        }
        public BrandViewModel GetBrandName(int id, string name)
        {
            return brandRepository.GetBrandbyName(id, name);
        }

        public int Update(int id, string name)
        {
            return brandRepository.UpdateBrand(id, name);
        }

        public List<BrandViewModel> GetBrandSummary()
        {
            return brandRepository.GetBrandSummary();
        }

        public List<BrandViewModel> GetBrandSummaryBySubType(int subTypeId)
        {
            return brandRepository.GetBrandSummaryBySubType(subTypeId);
        }





}
}
