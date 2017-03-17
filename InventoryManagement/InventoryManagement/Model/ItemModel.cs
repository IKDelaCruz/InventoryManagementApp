using InventoryManagement.Repository;
using InventoryManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Model
{
    public class ItemModel : BaseModel
    {
        List<ItemViewModel> itemCache;

        ItemTypeRepository catRepository;
        ItemRepository itemRepostory;
        ItemSubTypeRepository catSubRepository;

        public ItemModel()
        {
            catRepository = new ItemTypeRepository();
            itemRepostory = new ItemRepository();
            catSubRepository = new ItemSubTypeRepository();
        }

        public ReturnValueModel CreateNewItem(ItemViewModel newItem, int userId)
        {
            var rv = new ReturnValueModel();
            var newItemId = itemRepostory.Insert(newItem, userId);


            var catRepo = new ItemTypeRepository();
            var itemType = catRepo.QueryItemType(newItem.TypeId);
            var itemSubtype = catSubRepository.QuerySubTypeById(newItem.SubTypeId);


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
        private bool AllowChange(ItemStatus oldStatus, ItemStatus newStatus)
        {
            if (oldStatus == ItemStatus.Available)
                return true;
            if (oldStatus == ItemStatus.Borrowed && newStatus != ItemStatus.Available)
                return false;
            if (oldStatus == ItemStatus.Broken && newStatus != ItemStatus.Available)
                return false;
            if (oldStatus == ItemStatus.Reserved && (newStatus != ItemStatus.Borrowed && newStatus != ItemStatus.Available))
                return false;
            if (oldStatus == ItemStatus.Disposed)
                return false;

            return true;
        }
        public ReturnValueModel UpdateItemStatus(int itemId, int userId, ItemStatus oldStatus, ItemStatus newStatus)
        {
            var result = new ReturnValueModel();
            if(AllowChange(oldStatus, newStatus))
                result.Success = itemRepostory.UpdateItemStatus(itemId, userId, (int)newStatus);

            return result;
        }
        public ReturnValueModel UpdateItemImage(int itemId, Image img)
        {
            var result = new ReturnValueModel();

            byte[] bArr = Utils.ImageCon.imgToByteConverter(img);
            var success = itemRepostory.UpdateItemImage(itemId, bArr);
            result.Success = success;
            
            return result;
        }
        public bool UpdateItemStatusBySubtype(int id, int requestedby, ItemStatus status)
        {
            return itemRepostory.UpdateItemStatusBySubtype(id, requestedby, status);
        }

        public bool UpdateItemStatusToBroken(int id, int requestedby, ItemStatus status)
        {
            return itemRepostory.UpdateItemStatusToBroken(id, requestedby, status);
        }

        public bool UpdateItemStatusById(int id, ItemStatus status, int owner)
        {
            return itemRepostory.UpdateItemStatusById(id, status, owner);
        }
        public bool UpdateItemOwner(int id, int owner)
        {
            return itemRepostory.UpdateOwnerByStatus(id, owner);
        }
        public int createOS(int id, string name)
        {
            return itemRepostory.CreateOS(id, name);
        }
        public int UpdateOs(int id, string name)
        {
            return itemRepostory.UpdateOS(id, name);
        }


        public OSViewModel GetOSname(string os)
        {
            return itemRepostory.GetOSbyName(os);
        }


        public string GenerateAssetTag(string type, string subType, int itemId)
        {
            return type.Substring(0, 1).ToUpper() + subType.Substring(0, 2).ToUpper() + itemId.ToString("D8");
        }
        public List<BrandViewModel> GetBrandsBySubtype(int subtypeId)
        {
            return itemRepostory.GetBrandsBySubtype(subtypeId);
        }
        public List<BrandViewModel> GetBrands()
        {
            return itemRepostory.QueryBrands();
        }
        public List<ItemViewModel> GetItems(bool useCache)
        {
            if (useCache)
            {
                if (itemCache == null)
                {
                    itemCache = itemRepostory.QueryItems();
                }
            }
            else
            {
                itemCache = itemRepostory.QueryItems();
            }

            return itemCache;
        }
        public List<ItemViewModel> GetItemsByOwner(int userId)
        {
            return itemRepostory.QueryItemsByOwner(userId);
        }
        
        public List<ItemViewModel> GetItemsBySubType(int subTypeId)
        {
            return itemRepostory.QueryItemsBySubType(subTypeId);
        }
        public List<ItemViewModel> GetItemTypeSummary()
        {
            return itemRepostory.QueryItemTypeSummary();
        }
        public List<ItemViewModel> GetItemSubTypeSummary(int typeId)
        {
            return itemRepostory.QueryItemSubTypeSummary(typeId);
        }
        public ItemViewModel GetItem(int id)
        {
            //get value from two tables
            
            var item = itemRepostory.QueryItem(id);
            //var subcateg = catSubRepository.QuerySubTypeById(item.SubTypeId).Name;
            //var categ = catRepository.QueryItemType(item.TypeId).Name;
            //item.Brand = itemRepostory.QueryBrand(item.BrandId).Name;
            //item.SubType = subcateg;
            //item.Type = categ;
            //item.CurrentOwnerName = itemRepostory.QueryOwner(item.CurrentOwner);

            return item;
        }

        public List<ItemViewModel> QueryListItemStat()
        {
            return itemRepostory.QueryListofItemStat();
        }
        public Image GetItemImage(int id)
        {
            var raw = itemRepostory.GetItemIage(id);
            if (raw != null)
                return Utils.ImageCon.byteArrayToImage(raw);
            else
                return Image.FromFile(Utils.Helper.GetImageDirectory(@"\items\default.jpg"));
        }

        public List<OSViewModel> GetOSBySubtype()
        {
            return itemRepostory.QueryOSBySubtype();
        }


    }
}
