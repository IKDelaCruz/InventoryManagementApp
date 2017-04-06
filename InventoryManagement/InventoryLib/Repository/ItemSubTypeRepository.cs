using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagement.ViewModel;
using System.Drawing;
using InventoryLib.Repository;

namespace InventoryManagement.Repository
{
    public class ItemSubTypeRepository : BaseRepository
    {

        public List<ItemSubTypeViewModel> GetSubTypesByTypes(int categoryId)
        {
            var list = new List<ItemSubTypeViewModel>();

            var sub = InventoryDatabase.vw_item_subtype_summary.AsNoTracking().Where(x => x.ISTTypeId == categoryId).ToList();
            foreach (vw_item_subtype_summary s in sub)
            {
                list.Add(new ViewModel.ItemSubTypeViewModel
                {
                    Id = s.ISTSubTypeID,
                    ParentId = s.ISTTypeId,
                    Name = s.ISTSubType,
                    Count = s.ISTTotalAvailable ?? 0,
                    Picture = Utils.ImageCon.byteArrayToImage(s.ITemTypePicture)
                });
            }
            return list;
        }

        public List<ItemSubTypeViewModel> QuerySubTypes()
        {
            var subtypes = InventoryDatabase.item_subtype.ToList();
            List<ItemSubTypeViewModel> bList = new List<ItemSubTypeViewModel>();

            foreach (item_subtype s in subtypes)
            {
                bList.Add(new ItemSubTypeViewModel { Id = s.subtype_id, Name = s.subtype_name });
            }
            return bList;
        }

        public ItemSubTypeViewModel QuerySubTypeById(int id)
        {
            var categ = InventoryDatabase.item_subtype.FirstOrDefault(h => h.subtype_id == id);
            if (categ != null)
                return new ViewModel.ItemSubTypeViewModel
                {
                    Id = categ.subtype_id,
                    Name = categ.subtype_name,


                };
            else
                return null;
        }
        public ReturnValueRepo DeleteSubType(int id)
        {
            var result = new ReturnValueRepo();
            var subType = InventoryDatabase.item_subtype.FirstOrDefault(h => h.subtype_id == id);
            if (subType != null)
            {
                InventoryDatabase.item_subtype.Remove(subType);
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
            var subtype = InventoryDatabase.item_subtype.FirstOrDefault(h => h.subtype_name == name);
            if (subtype != null)
            {
                return new ItemSubTypeViewModel
                {
                    Id = subtype.subtype_id,
                    Name = subtype.subtype_name,

                };
            }

            return null;
        }


        public ReturnValueRepo Create(int parentId, string name)
        {
            var result = new ReturnValueRepo();
            var cat = InventoryDatabase.item_subtype.FirstOrDefault(s => s.subtype_name.Equals(name));

            if (cat == null)
            {
                var newItemSubtype = new item_subtype { subtype_parent_id = parentId, subtype_name = name };

                InventoryDatabase.item_subtype.Add(newItemSubtype);
                if (InventoryDatabase.SaveChanges() > 0)
                {
                    result.Param1 = newItemSubtype.subtype_id.ToString();
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
            var item = InventoryDatabase.item_subtype_image.FirstOrDefault(x => x.subtype_image_id == typeId);

            if (item != null)
            {

                item.subtype_image_picture = bArr;
                InventoryDatabase.SaveChanges();

                return true;
            }
            else
            {
                InventoryDatabase.item_subtype_image.Add(new item_subtype_image
                {
                    subtype_image_subtype_id = typeId,
                    subtype_image_picture = bArr
                });
                InventoryDatabase.SaveChanges();
                return true;
            }

        }

        public byte[] GetItemImage(int typeId)
        {
            var item = InventoryDatabase.item_subtype_image.FirstOrDefault(x => x.subtype_image_id == typeId);
            if (item != null)
            {
                return item.subtype_image_picture;
            }
            return null;
        }

        public List<ItemSubTypeViewModel> GetItemImage()
        {
            var list = new List<ItemSubTypeViewModel>();
            var item = InventoryDatabase.item_subtype_image.ToList();
           foreach(item_subtype_image it in item)
            {
                list.Add(new ItemSubTypeViewModel {
                    Id = it.subtype_image_id,
                    Picture = Utils.ImageCon.byteArrayToImage(it.subtype_image_picture),
                    ParentId = it.subtype_image_subtype_id
                });


            }
            return list;
        }
        
       
    }

}
