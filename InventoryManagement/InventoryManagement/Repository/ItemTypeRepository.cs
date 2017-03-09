using System;
using System.Collections.Generic;
using System.Linq;
using InventoryManagement.ViewModel;
using System.Drawing;

namespace InventoryManagement.Repository
{
    public class ItemTypeRepository : BaseRepository
    {
        public List<ItemTypeViewModel> QueryItemTypes()
        {
            var list = new List<ItemTypeViewModel>();
            var categ = InventoryDatabase.item_type.OrderBy(h => h.item_type_name).ToList();

            foreach (item_type c in categ)
            {

                list.Add(new ItemTypeViewModel

                {
                    Id = c.item_type_id,
                    Name = c.item_type_name
                });
             

            }
            return list;

        }

        public ItemTypeViewModel QueryItemTypeByName(string name)
        {
            var type = InventoryDatabase.item_type.FirstOrDefault(h => h.item_type_name == name);
            if (type != null)
            {
                return new ItemTypeViewModel
                {
                    Id = type.item_type_id,
                    Name = type.item_type_name,

                };
            }

            return null;
        }


        public ItemTypeViewModel QueryItemType(int id)
        {
            var categ = InventoryDatabase.item_type.FirstOrDefault(h => h.item_type_id == id);
            if (categ != null)
                return new ItemTypeViewModel
                {
                    Id = categ.item_type_id,
                    Name = categ.item_type_name,

                };
            else
                return null;
        }


        public ReturnValueRepo Create(string name)
        {
            var result = new ReturnValueRepo();
            var cat = InventoryDatabase.item_type.FirstOrDefault(s => s.item_type_name.Equals(name));
            if (cat == null)
            {
                var newCat = new item_type() { item_type_name = name };
                InventoryDatabase.item_type.Add(newCat);
                if (InventoryDatabase.SaveChanges() > 0)
                {
                    result.Success = true;
                    result.Param1 = newCat.item_type_id.ToString();
                }
            }
            else
            {
                result.Message = "Type already exist!";
            }
            
            return result;

        }

        public int Update(int id, string name)
        {
            var cat = InventoryDatabase.item_type.FirstOrDefault(s => s.item_type_id == id);

            if (cat != null)
            {
                var catExist = InventoryDatabase.item_type.FirstOrDefault(s => s.item_type_name == name);


                //Name already exist
                if (catExist != null)
                {
                    if (catExist.item_type_id == id)
                    {
                        return -1;
                    }
                    return -2;
                }

                cat.item_type_name = name;
            }

            InventoryDatabase.SaveChanges();
            return 1;
        }

        public int Delete(int id)
        {
            var cat = InventoryDatabase.item_type.FirstOrDefault(s => s.item_type_id == id);

            if (cat != null)
            {
                InventoryDatabase.item_type.Remove(cat);
            }

            InventoryDatabase.SaveChanges();
            return 1;
        }

        public bool UpdateItemTypeImage(int typeId, byte[] bArr)
        {
            //var item = InventoryDatabase.Items.FirstOrDefault(h => h.id == itemId);
            var item = InventoryDatabase.item_type_image.FirstOrDefault(x => x.item_type_image_type_id == typeId);

            if (item != null)
            {

                item.item_type_image_picture = bArr;
                InventoryDatabase.SaveChanges();

                return true;
            }
            else
            {
                InventoryDatabase.item_type_image.Add(new item_type_image
                {
                    item_type_image_type_id = typeId,
                    item_type_image_picture = bArr
                });
                InventoryDatabase.SaveChanges();
                return true;
            }

        }

        public byte[] GetItemIage(int typeId)
        {
            var item = InventoryDatabase.item_type_image.FirstOrDefault(x => x.item_type_image_type_id == typeId);
            if (item != null)
            {
                return item.item_type_image_picture;
            }
            return null;
        }

    }
}
