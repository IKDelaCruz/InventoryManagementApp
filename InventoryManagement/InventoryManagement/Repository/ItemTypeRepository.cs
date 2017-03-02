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
            var categ = InventoryDatabase.ItemTypes.OrderBy(h => h.type).ToList();

            foreach (ItemType c in categ)
            {

                list.Add(new ItemTypeViewModel

                {
                    Id = c.id,
                    Name = c.type
                });
             

            }
            return list;

        }

        public ItemTypeViewModel QueryItemTypeByName(string name)
        {
            var type = InventoryDatabase.ItemTypes.FirstOrDefault(h => h.type == name);
            if (type != null)
            {
                return new ItemTypeViewModel
                {
                    Id = type.id,
                    Name = type.type,

                };
            }

            return null;
        }


        public ItemTypeViewModel QueryItemType(int id)
        {
            var categ = InventoryDatabase.ItemTypes.FirstOrDefault(h => h.id == id);
            if (categ != null)
                return new ItemTypeViewModel
                {
                    Id = categ.id,
                    Name = categ.type,

                };
            else
                return null;
        }


        public ReturnValueRepo Create(string name)
        {
            var result = new ReturnValueRepo();
            var cat = InventoryDatabase.ItemTypes.FirstOrDefault(s => s.type.Equals(name));
            if (cat == null)
            {
                var newCat = new ItemType() { type = name };
                InventoryDatabase.ItemTypes.Add(newCat);
                if (InventoryDatabase.SaveChanges() > 0)
                {
                    result.Success = true;
                    result.Param1 = newCat.id.ToString();
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
            var cat = InventoryDatabase.ItemTypes.FirstOrDefault(s => s.id == id);

            if (cat != null)
            {
                var catExist = InventoryDatabase.ItemTypes.FirstOrDefault(s => s.type == name);


                //Name already exist
                if (catExist != null)
                {
                    if (catExist.id == id)
                    {
                        return -1;
                    }
                    return -2;
                }

                cat.type = name;
            }

            InventoryDatabase.SaveChanges();
            return 1;
        }

        public int Delete(int id)
        {
            var cat = InventoryDatabase.ItemTypes.FirstOrDefault(s => s.id == id);

            if (cat != null)
            {
                InventoryDatabase.ItemTypes.Remove(cat);
            }

            InventoryDatabase.SaveChanges();
            return 1;
        }

        public bool UpdateItemTypeImage(int typeId, byte[] bArr)
        {
            //var item = InventoryDatabase.Items.FirstOrDefault(h => h.id == itemId);
            var item = InventoryDatabase.ItemTypeImages.FirstOrDefault(x => x.type_id == typeId);

            if (item != null)
            {

                item.picture = bArr;
                InventoryDatabase.SaveChanges();

                return true;
            }
            else
            {
                InventoryDatabase.ItemTypeImages.Add(new ItemTypeImage
                {
                    type_id = typeId,
                    picture = bArr
                });
                InventoryDatabase.SaveChanges();
                return true;
            }

        }

        public byte[] GetItemIage(int typeId)
        {
            var item = InventoryDatabase.ItemTypeImages.FirstOrDefault(x => x.type_id == typeId);
            if (item != null)
            {
                return item.picture;
            }
            return null;
        }

    }
}
