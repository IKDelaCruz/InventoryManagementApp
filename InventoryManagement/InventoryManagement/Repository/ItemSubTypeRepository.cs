using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagement.ViewModel;


namespace InventoryManagement.Repository
{
    public class ItemSubTypeRepository : BaseRepository
    {

        public List<ItemSubTypeViewModel> GetSubTypesByTypes(int categoryId)
        {
            var list = new List<ItemSubTypeViewModel>();

            var sub = InventoryDatabase.vwItemSubTypeCounts.AsNoTracking().Where(x => x.TypeId == categoryId).ToList();
            foreach (vwItemSubTypeCount s in sub)
            {
                list.Add(new ViewModel.ItemSubTypeViewModel
                {
                    Id = s.SubTypeId,
                    ParentId = s.TypeId ?? 0,
                    Name = s.SubTypeName,
                    Count = s.SubTypeItemCount ?? 0,
                    Picture = Utils.ImageCon.byteArrayToImage(s.Picture)
                });
            }
            return list;
        }

        public List<ItemSubTypeViewModel> QuerySubTypes()
        {
            var subtypes = InventoryDatabase.ItemSubtypes.ToList();
            List<ItemSubTypeViewModel> bList = new List<ItemSubTypeViewModel>();

            foreach (ItemSubtype s in subtypes)
            {
                bList.Add(new ItemSubTypeViewModel { Id = s.id, Name = s.name });
            }
            return bList;
        }

        public ItemSubTypeViewModel QuerySubTypeById(int id)
        {
            var categ = InventoryDatabase.ItemSubtypes.FirstOrDefault(h => h.id == id);
            if (categ != null)
                return new ViewModel.ItemSubTypeViewModel
                {
                    Id = categ.id,
                    Name = categ.name,


                };
            else
                return null;
        }
        public ReturnValueRepo DeleteSubType(int id)
        {
            var result = new ReturnValueRepo();
            var subType = InventoryDatabase.ItemSubtypes.FirstOrDefault(h => h.id == id);
            if (subType != null)
            {
                InventoryDatabase.ItemSubtypes.Remove(subType);
                try
                {
                    InventoryDatabase.SaveChanges();
                    result.Success = true;
                }
                catch (Exception ex)
                {
                    result.Success = false;
                    result.Message = ex.Message;
                    result.Param1 = ex.InnerException != null ? ex.InnerException.Message : "";
                }
            }

            return result;
        }

        public ItemSubTypeViewModel GetSubtypeByName(string name)
        {
            var subtype = InventoryDatabase.ItemSubtypes.FirstOrDefault(h => h.name == name);
            if (subtype != null)
            {
                return new ItemSubTypeViewModel
                {
                    Id = subtype.id,
                    Name = subtype.name,

                };
            }

            return null;
        }


        public ReturnValueRepo Create(int parentId, string name)
        {
            var result = new ReturnValueRepo();
            var cat = InventoryDatabase.ItemSubtypes.FirstOrDefault(s => s.name.Equals(name));
            if (cat == null)
            {
                var newItemSubtype = new ItemSubtype { type_id = parentId, name = name };

                InventoryDatabase.ItemSubtypes.Add(newItemSubtype);
                if (InventoryDatabase.SaveChanges() > 0)
                {
                    result.Param1 = newItemSubtype.id.ToString();
                    result.Success = true;
                }
                else
                {
                    result.Message = "Error creating subtype!";
                }
               
            }
            else
            {
                result.Message = "Subtype already exist!";
            }
            return result;
            

        }

        public bool UpdateItemTypeImage(int typeId, byte[] bArr)
        {
            //var item = InventoryDatabase.Items.FirstOrDefault(h => h.id == itemId);
            var item = InventoryDatabase.ItemSubTypeImages.FirstOrDefault(x => x.subtype_id == typeId);

            if (item != null)
            {

                item.picture = bArr;
                InventoryDatabase.SaveChanges();

                return true;
            }
            else
            {
                InventoryDatabase.ItemSubTypeImages.Add(new ItemSubTypeImage
                {
                    subtype_id = typeId,
                    picture = bArr
                });
                InventoryDatabase.SaveChanges();
                return true;
            }

        }

        public byte[] GetItemImage(int typeId)
        {
            var item = InventoryDatabase.ItemSubTypeImages.FirstOrDefault(x => x.subtype_id == typeId);
            if (item != null)
            {
                return item.picture;
            }
            return null;
        }

        public List<ItemSubTypeViewModel> GetItemImage()
        {
            var list = new List<ItemSubTypeViewModel>();
            var item = InventoryDatabase.ItemSubTypeImages.ToList();
           foreach(ItemSubTypeImage it in item)
            {
                list.Add(new ItemSubTypeViewModel {
                    Id = it.subtype_id,
                    Picture = Utils.ImageCon.byteArrayToImage(it.picture)
                });


            }
            return list;
        }
    }

}
