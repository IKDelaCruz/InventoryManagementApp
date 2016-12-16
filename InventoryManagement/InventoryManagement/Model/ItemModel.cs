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
        ItemRepository ir;
        public ItemModel()
        {
            ir = new ItemRepository();
        }
        public bool CreateNewItem(ItemViewModel newItem, int userId)
        {
            var newItemId = ir.Insert(newItem, userId);
            var assetTag = GenerateAssetTag(newItem.Type, newItem.SubType, newItemId);

            return ir.AttachAssetTag(newItemId, assetTag); 
        }
        public string GenerateAssetTag(PrimaryItemType type, SecondaryItemType subType, int itemId)
        {
            return type.ToString().Substring(0, 1).ToUpper() + subType.ToString().Substring(0, 2).ToUpper() + itemId.ToString("D8");
        }
        public List<BrandViewModel> GetBrands()
        {
            return ir.QueryBrands();
        }
        public List<ItemViewModel> GetItems()
        {
            return ir.QueryItems();
        }
        public ItemViewModel GetItem(int id)
        {
            var item = ir.QueryItem(id);
            item.Brand = ir.QueryBrand(item.BrandId).Name;
            item.CurrentOwnerName = ir.QueryOwner(item.CurrentOwner);
            return item;
        }
    }
}
