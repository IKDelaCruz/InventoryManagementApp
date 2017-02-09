using InventoryManagement.Repository;
using InventoryManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Model
{
    public class ItemModel : BaseModel
    {
        CategoryRepository catRepository;
        ItemRepository itemRepostory;
        SubCategoryRepository catSubRepository;

        public ItemModel()
        {
            catRepository = new CategoryRepository();
            itemRepostory = new ItemRepository();
            catSubRepository = new SubCategoryRepository();
        }
        public ReturnValueModel CreateNewItem(ItemViewModel newItem, int userId)
        {
            var rv = new ReturnValueModel();
            var newItemId = itemRepostory.Insert(newItem, userId);


            var catRepo = new CategoryRepository();
            var itemType = catRepo.QueryCategory(newItem.TypeId);
            var itemSubtype = catSubRepository.QuerySubcategory(newItem.SubTypeId);





            var assetTag = GenerateAssetTag(itemType.Name, itemSubtype.Name, newItemId);

            rv.Success = itemRepostory.AttachAssetTag(newItemId, assetTag);
            if (rv.Success)
            {
                rv.Param1 = newItemId.ToString();
                rv.Param2 = assetTag;
            }

            return rv;
        }
        public ReturnValueModel UpdateItem(ItemViewModel newItem, int userId)
        {
            var rv = new ReturnValueModel();
            rv.Success = itemRepostory.Update(newItem, userId);

            if (rv.Success)
            {
               
            }

            return rv;
        }
        public ReturnValueModel UpdateItemStatus(int itemId, int userId, ItemStatus itemStatus)
        {
            var result = new ReturnValueModel();

            var success = itemRepostory.UpdateItemStatus(itemId, userId, (int)itemStatus);

            result.Success = success;
            //result.Param1 = itemStatus.ToString();

            return result;
        }
        public string GenerateAssetTag(string type, string subType, int itemId)
        {
            return type.Substring(0, 1).ToUpper() + subType.Substring(0, 2).ToUpper() + itemId.ToString("D8");
        }
        public List<BrandViewModel> GetBrands()
        {
            return itemRepostory.QueryBrands();
        }
        public List<ItemViewModel> GetItems()
        {
            return itemRepostory.QueryItems();
        }
        public ItemViewModel GetItem(int id)
        {
            var item = itemRepostory.QueryItem(id);
            item.Brand = itemRepostory.QueryBrand(item.BrandId).Name;
            item.CurrentOwnerName = itemRepostory.QueryOwner(item.CurrentOwner);
            return item;
        }
    }
}
