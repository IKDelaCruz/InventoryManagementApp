using InventoryManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Repository
{
    public class ItemRepository : BaseRepository
    {
        public object ItemModel { get; internal set; }

        public int Insert(ItemViewModel newItem, int userId)
        {

            var itm = new item
            {
                item_name = newItem.Name,
                item_brand_id = newItem.BrandId,
                item_description = newItem.Description,
                item_subtype_id = (int)newItem.SubTypeId,
                item_type_id = (int)newItem.TypeId,
           
                item_last_updated_user = newItem.LastUpdatedUserId,
                item_lifespan = newItem.LifeSpan,
                item_model = newItem.Model,
                item_purchase_date = newItem.PurchaseDate,
                item_purchase_price = newItem.PurchasePrice,
                item_current_value = newItem.Currentvalue,
                item_salvage_value = newItem.SalvageValue,
                item_current_owner = newItem.CurrentOwner,
                item_serial = newItem.Serial,
                item_status = (int)newItem.Status,
                item_asset_tag = newItem.AssetTag,
                item_os_id = (int)newItem.OS,
                item_processor_id = (int)newItem.Processor,
                item_memory_id = (int)newItem.Memory,
                item_hdd1_id = (int)newItem.HDD1,
                item_hdd2_id = (int)newItem.HDD2,
                item_login_type = (int)newItem.LoginType,

            };
            InventoryDatabase.items.Add(itm);

            try
            {
                InventoryDatabase.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return itm.item_id;
        }



        public bool Update(ItemViewModel newItem, int userId)
        {
            var item = InventoryDatabase.items.FirstOrDefault(h => h.item_id == newItem.Id);

            if (item != null)
            {
                item.item_name = newItem.Name;
                item.item_brand_id = newItem.BrandId;
                item.item_description = newItem.Description;
                item.item_subtype_id = (int)newItem.SubTypeId;
                item.item_type_id = (int)newItem.TypeId;
                item.item_last_updated = newItem.LastUpdatedDate;
                item.item_last_updated_user = newItem.LastUpdatedUserId;
                item.item_lifespan = newItem.LifeSpan;
                item.item_model = newItem.Model;
                item.item_purchase_date = newItem.PurchaseDate;
                item.item_purchase_price = newItem.PurchasePrice;
                item.item_current_value = newItem.Currentvalue;
                item.item_salvage_value = newItem.SalvageValue;
                //item.item_current_owner = newItem.CurrentOwner;
                item.item_serial = newItem.Serial;
                item.item_status = (int)newItem.Status;
                item.item_os_id = (int)newItem.OS;
                item.item_processor_id = (int)newItem.Processor;
                item.item_memory_id = (int)newItem.Memory;
                item.item_hdd1_id = (int)newItem.HDD1;
                item.item_hdd2_id = (int)newItem.HDD2;
                item.item_salvage_value = newItem.SalvageValue;
                item.item_login_type = (int)newItem.LoginType;
                item.item_printer_type = (int)newItem.PrinterType;
                item.item_ip_address = newItem.NetworkIP;
                item.item_ip_subnet_mask = newItem.NetworkSubnet;
                item.item_ip_gateway = newItem.NetworkGateway;

                InventoryDatabase.SaveChanges();

                return true;
            }

            return false;
        }

        public bool UpdateItemStatusBySubtype(int subtypeId, int reqby, ItemStatus status)
        {

            var item = InventoryDatabase.items.FirstOrDefault(x => x.item_subtype_id == subtypeId && x.item_status == 0);
            if (item != null)
            {
                item.item_status = 2;
                item.item_current_owner = reqby;
                item.item_last_updated = DateTime.Now;
                InventoryDatabase.SaveChanges();

                return true;
            }
            return false;

        }

        public bool UpdateItemStatusToBroken(int subtypeId, int reqby, ItemStatus status)
        {
            var item = InventoryDatabase.items.FirstOrDefault(x => x.item_subtype_id == subtypeId && x.item_status == 1 && x.item_current_owner == reqby);
            if (item != null)
            {
                item.item_status = (int)ItemStatus.Broken;
                item.item_current_owner = reqby;
                item.item_last_updated = DateTime.Now;
                InventoryDatabase.SaveChanges();

                return true;
            }
            return false;

        }

        public bool UpdateItemStatusById(int id, ItemStatus status, int curowner)
        {

            var item = InventoryDatabase.items.FirstOrDefault(x => x.item_id == id);
            if (item != null)
            {
                item.item_status = (int)status;
                item.item_last_updated = DateTime.Now;
                item.item_current_owner = curowner;

                InventoryDatabase.SaveChanges();

                return true;
            }
            return false;

        }

        public bool UpdateOwnerByStatus(int id, int owner)
        {

            var item = InventoryDatabase.items.FirstOrDefault(x => x.item_id == id);
            if (item != null)
            {
                item.item_current_owner = owner;

                InventoryDatabase.SaveChanges();

                return true;
            }
            return false;

        }
        public bool AttachAssetTag(int itemId, string assetTag)
        {
            var item = InventoryDatabase.items.FirstOrDefault(h => h.item_id == itemId);

            if (item != null)
            {
                item.item_asset_tag = assetTag;
                InventoryDatabase.SaveChanges();

                return true;
            }
            return false;
        }
        public bool UpdateItemStatus(int itemId, int userId, int itemStatus)
        {
            //var item = InventoryDatabase.Items.FirstOrDefault(h => h.id == itemId);
            var item = InventoryDatabase.items.FirstOrDefault(x => x.item_id == itemId);

            if (item != null)
            {

                item.item_status = itemStatus;
                item.item_current_owner = userId;
                InventoryDatabase.SaveChanges();

                return true;
            }
            return false;
        }
        public bool UpdateItemImage(int itemId, byte[] bArr)
        {
            //var item = InventoryDatabase.Items.FirstOrDefault(h => h.id == itemId);
            var item = InventoryDatabase.item_image.FirstOrDefault(x => x.item_image_parent == itemId);

            if (item != null)
            {

                item.item_image_picture = bArr;
                InventoryDatabase.SaveChanges();

                return true;
            }
            else
            {
                InventoryDatabase.item_image.Add(new item_image
                {
                    item_image_parent = itemId,
                    item_image_picture = bArr
                });
                InventoryDatabase.SaveChanges();
                return true;
            }

        }
        public byte[] GetItemIage(int itemId)
        {
            var item = InventoryDatabase.item_image.FirstOrDefault(x => x.item_image_parent == itemId);
            if (item != null)
            {
                return item.item_image_picture;
            }
            return null;
        }
        #region --- Queries ---

        public int CreateOS(int id, string name)
        {

            var newOs = new operation_system() { os_id = id, os_name = name };
            InventoryDatabase.operation_system.Add(newOs);
            if (InventoryDatabase.SaveChanges() > 0)
                return newOs.os_id;


            return -1;


        }

        public OSViewModel GetOSbyName(string os)
        {
            var OS = InventoryDatabase.operation_system.FirstOrDefault(h =>  h.os_name == os);
            if (OS != null)
            {
                return new OSViewModel
                {
                    Id = OS.os_id,
                    ParentId = OS.os_id,
                    Name = OS.os_name,

                };
            }

              return new OSViewModel
            {
                Id = 1,
                ParentId = 1,
                Name = "Unknown",

            }; ;
        }


        public int UpdateOS(int id, string name)
        {
            var os = InventoryDatabase.operation_system.FirstOrDefault(b => b.os_id == id);

            if (os != null)
            {
                var osExists = InventoryDatabase.operation_system.FirstOrDefault(b => b.os_name == name);


                //Name already exist
                if (osExists != null)
                {
                    if (osExists.os_id == id)
                    {
                        return -1;
                    }
                    return -2;
                }

                os.os_name = name;
            }
            InventoryDatabase.SaveChanges();
            return 1;
        }
        public List<BrandViewModel> QueryBrands()
        {
            var brands = InventoryDatabase.brands.ToList();
            List<BrandViewModel> bList = new List<BrandViewModel>();

            foreach (brand b in brands)
            {
                bList.Add(new BrandViewModel { Id = b.brand_id, ParentId = b.brand_parent_id, Name = b.brand_name });
            }
            return bList;
        }

        public List<BrandViewModel> GetBrandsBySubtype(int subtypeId)
        {
            var brandslist = new List<BrandViewModel>();

            var br = InventoryDatabase.brands.Where(x => x.brand_parent_id == subtypeId).ToList();

            if (subtypeId == 0)
            {
                br = InventoryDatabase.brands.ToList();
            }
            foreach (brand b in br)
            {
                brandslist.Add(new ViewModel.BrandViewModel
                {
                    Id = b.brand_id,
                    ParentId = b.brand_parent_id,
                    Name = b.brand_name,
                });
            }

            return brandslist;
        }
        public BrandViewModel QueryBrand(int id)
        {
            var brands = InventoryDatabase.brands.FirstOrDefault(h => h.brand_id == id);

            if (brands != null)
            {
                return new BrandViewModel
                {
                    Id = brands.brand_id,
                    ParentId = brands.brand_parent_id,
                    Name = brands.brand_name
                };
            }
            return null;
        }

        public List<OSViewModel> QueryOSBySubtype()
        {
            var OSList = new List<OSViewModel>();

            var operatingsystems = InventoryDatabase.operation_system.OrderBy(h=> h.os_name).ToList();
            foreach (operation_system o in operatingsystems)
            {
                OSList.Add(new ViewModel.OSViewModel
                {
                    Id = o.os_id,
                    ParentId = o.os_id,
                    Name = o.os_name,
                });
            }

            return OSList;
        }

        public List<ItemViewModel> QueryItems()
        {
            var items = InventoryDatabase.vw_item_detail.AsNoTracking().ToList();
            List<ItemViewModel> iList = new List<ItemViewModel>();

            foreach (vw_item_detail i in items)
            {
                iList.Add(new ItemViewModel
                {
                    Id = i.item_id,
                    AssetTag = i.AssetTag,
                    Name = i.item_name,
                    Description = i.item_description,
                    TypeId = Convert.ToInt32(i.ItemTypeId),
                    Type = i.TypeName,
                    SubTypeId = Convert.ToInt32(i.ItemSubTypeId),
                    SubType = i.SubTypeName,
                    BrandId = i.BrandId ?? 13,
                    Model = i.item_model,
                    Serial = i.item_serial,
                    Status = (ItemStatus)i.item_status,
                    CurrentOwner = i.CurrentOwner ?? 0,
                    CurrentOwnerName = i.Username,
                    LastUpdatedDate = i.LastUpdated ?? DateTime.MinValue,
                    PurchaseDate = i.PurchaseDate ?? DateTime.MinValue,
                    PurchasePrice = i.PurchasePrice,
                    LifeSpan = i.LifeSpan ?? 5,
                    Currentvalue = i.CurrentValue,
                    SalvageValue = i.SalvageValue ?? 0
                });
            }
            return iList;
        }

        public List<ItemViewModel> QueryItemsByOwner(int ownerId)
        {
            var items = InventoryDatabase.vw_item_detail.AsNoTracking().Where(h => h.CurrentOwner == ownerId).ToList();
            List<ItemViewModel> iList = new List<ItemViewModel>();

            foreach (vw_item_detail i in items)
            {
                iList.Add(new ItemViewModel
                {
                    Id = i.item_id,
                    AssetTag = i.AssetTag,
                    Name = i.item_name,
                    Description = i.item_description,
                    TypeId = Convert.ToInt32(i.ItemTypeId),
                    Type = i.TypeName,
                    SubTypeId = Convert.ToInt32(i.ItemSubTypeId),
                    SubType = i.SubTypeName,
                    BrandId = i.BrandId ?? 13,
                    Model = i.item_model,
                    Serial = i.item_serial,
                    Status = (ItemStatus)i.item_status,
                    CurrentOwner = i.CurrentOwner ?? 0,
                    CurrentOwnerName = i.Username,
                    LastUpdatedDate = i.LastUpdated ?? DateTime.MinValue,
                    PurchaseDate = i.PurchaseDate ?? DateTime.MinValue,
                    PurchasePrice = i.PurchasePrice,
                    LifeSpan = i.LifeSpan ?? 5,
                    Currentvalue = i.CurrentValue,
                    SalvageValue = i.SalvageValue ?? 0
                });
            }
            return iList;
        }

        public List<ItemViewModel> QueryItemsBySubType(int subtypeId)
        {
            var items = InventoryDatabase.vw_item_detail.AsNoTracking().Where(h => h.ItemSubTypeId == subtypeId).ToList();
            List<ItemViewModel> iList = new List<ItemViewModel>();

            foreach (vw_item_detail i in items)
            {
                iList.Add(new ItemViewModel
                {
                    Id = i.item_id,
                    AssetTag = i.AssetTag,
                    Name = i.item_name,
                    Description = i.item_description,
                    TypeId = Convert.ToInt32(i.ItemTypeId),
                    //Type = i.ItemType.type,
                    SubTypeId = Convert.ToInt32(i.ItemSubTypeId),
                    //SubType = i.ItemSubtype.subtype,
                    BrandId = i.BrandId ?? 13,
                    Model = i.item_model,
                    Serial = i.item_serial,
                    Status = (ItemStatus)i.item_status,
                    CurrentOwner = i.CurrentOwner ?? 0,
                    CurrentOwnerName = i.Username,
                    LastUpdatedDate = i.LastUpdated ?? DateTime.MinValue,
                    PurchaseDate = i.PurchaseDate ?? DateTime.MinValue,
                    PurchasePrice = i.PurchasePrice,
                    LifeSpan = i.LifeSpan ?? 5,
                    Currentvalue = i.CurrentValue
                });
            }
            return iList;
        }

        public List<ItemViewModel> QueryItemTypeSummary()
        {
            var items = InventoryDatabase.vw_item_type_summary.AsNoTracking().ToList();
            List<ItemViewModel> iList = new List<ItemViewModel>();

            foreach (vw_item_type_summary s in items)
            {
                iList.Add(new ItemViewModel
                {
                    Id = s.ITTypeId,
                    TypeId = s.ITTypeId,
                    SubTypeId = s.ITTypeId,
                    Name = s.ITTypeName,
                    SummaryCount = s.ITTotalAvailable ?? 0,
                    IsSummary = true,
                    Picture = Utils.ImageCon.byteArrayToImage(s.Picture)
                });
            }
            return iList;
        }

        public List<ItemViewModel> QueryItemSubTypeSummary(int typeId)
        {
            var items = InventoryDatabase.vw_item_subtype_summary.Where(x => x.ISTTypeId == typeId).ToList();
            List<ItemViewModel> iList = new List<ItemViewModel>();

            foreach (vw_item_subtype_summary s in items)
            {
                iList.Add(new ItemViewModel
                {
                    Id = s.ISTSubTypeID,
                    TypeId = s.ISTSubTypeID,
                    SubTypeId = s.ISTSubTypeID,
                    Name = s.ISTSubType,
                    SummaryCount = s.ISTTotalAvailable ?? 0,
                    IsSummary = true,
                    Picture = Utils.ImageCon.byteArrayToImage(s.ITemTypePicture)
                });
            }
            return iList;
        }

        public List<ItemViewModel> QueryListofItemStat()
        {
            var statList = new List<ItemViewModel>();
            var sub = InventoryDatabase.items.ToList();

            //var categ = categ1.GroupBy(i => i.id).Select(group => group.First());

            //List<CategorySubcategoryViewModel> cList = new List<CategorySubcategoryViewModel>();

            foreach (item s in sub)
            {

                statList.Add(new ItemViewModel

                {
                    Id = s.item_id,
                    AssetTag = s.item_asset_tag,
                    Status = (ItemStatus)s.item_status,

                });
                //subcategory = c.subtype 

            }
            return statList;

        }
        public ItemViewModel QueryItem(int id)
        {
            var i = InventoryDatabase.vw_item_detail.AsNoTracking().FirstOrDefault(h => h.item_id == id);

            return new ItemViewModel
            {
                Id = i.item_id,
                AssetTag = i.AssetTag,
                Name = i.item_name,
                Description = i.item_description,
                TypeId = i.ItemTypeId,
                //Type = i.ItemType.type,
                SubTypeId = i.ItemSubTypeId,
                //SubType = i.ItemSubtype.subtype,
                BrandId = i.BrandId ?? 13,
                Model = i.item_model,
                Serial = i.item_serial,
                Status = (ItemStatus)i.item_status,
                CurrentOwner = i.CurrentOwner ?? 0,
                CurrentDepartment = i.UserDepartment ?? 0,
                LastUpdatedDate = i.LastUpdated ?? DateTime.MinValue,
                PurchaseDate = i.PurchaseDate ?? DateTime.MinValue,
                PurchasePrice = i.PurchasePrice,
                LifeSpan = i.LifeSpan ?? 5,
                Currentvalue = i.CurrentValue,
                OS = (int)(i.OsId ?? 0),
                Processor = (ItemProcessors)(i.ProcessorId ?? 0),
                Memory = (ItemMemory)(i.MemoryId ?? 0),
                HDD1 = (ItemHDDCapacity)(i.HddId ?? 0),
                HDD2 = (ItemHDDCapacity)(i.Hdd2Id ?? 0),
                SalvageValue = i.SalvageValue ?? 0,
                Type = i.TypeName,
                SubType = i.SubTypeName,
                Brand = i.BrandName,
                CurrentOwnerName = i.Username,
                CurrentCompany = i.UserCompany ?? 0,
                LoginType = (ItemLoginType)(i.ItemLoginType ?? 0),
                PrinterType = (PrinterType)(i.PrinterType ?? 0),
                CurrentCompanyName = i.UserCompanyName,
                CurrentDepartmentName = i.UserDepartmentName,
                NetworkIP = i.NetworkIP,
                NetworkSubnet = i.NetworkSubnet,
                NetworkGateway = i.NetworkGateway
            };
        }
        public string QueryOwner(int id)
        {
            var user = InventoryDatabase.users.FirstOrDefault(h => h.user_id == id);
            if (user != null)
            {
                return user.user_last_name + ", " + user.user_first_name;
            }
            else
            {
                return "System";
            }
        }
        #endregion

    }
}


