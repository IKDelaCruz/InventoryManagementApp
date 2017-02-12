﻿using System;
using System.Collections.Generic;
using System.Linq;
using InventoryManagement.ViewModel;

namespace InventoryManagement.Repository
{
    public class CategoryRepository : BaseRepository
    {
        public List<CategoryViewModel> QueryCategories()
        {
            var list = new List<CategoryViewModel>();
            var categ = InventoryDatabase.ItemTypes.ToList();

            //var categ = categ1.GroupBy(i => i.id).Select(group => group.First());

            //List<CategorySubcategoryViewModel> cList = new List<CategorySubcategoryViewModel>();

            foreach (ItemType c in categ)
            {

                list.Add(new CategoryViewModel

                {
                    Id = c.id,
                    Name = c.type
                });
                //subcategory = c.subtype 

            }
            return list;

        }


        public CategoryViewModel QueryCategory(int id)
        {
            var categ = InventoryDatabase.ItemTypes.FirstOrDefault(h => h.id == id);
            if (categ != null)
                return new CategoryViewModel
                {
                    Id = categ.id,
                    Name = categ.type,

                };
            else
                return null;
        }


        public int Create(string name)
        {
            var cat = InventoryDatabase.ItemTypes.FirstOrDefault(s => s.type.Equals(name));
            if (cat == null)
            {
                var newCat = new ItemType() { type = name };
                InventoryDatabase.ItemTypes.Add(newCat);
                if (InventoryDatabase.SaveChanges() > 0)
                    return newCat.id;

                //Unable to save 
                return -1;
            }
            //Already exist;
            return -2;

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
        public int CreateSubCateg(int id, string name)
        {
            var cat = InventoryDatabase.ItemSubtypes.FirstOrDefault(s => s.subtype.Equals(name));
            if (cat == null)
            {
                var newCat = new ItemSubtype() { type_id = id, subtype = name };
                InventoryDatabase.ItemSubtypes.Add(newCat);
                if (InventoryDatabase.SaveChanges() > 0) 
                    return newCat.id;

                //Unable to save 
                return -1;
            }
            //Already exist;
            return -2;

        }

        public int UpdateSubCateg(int id, string name)
        {
            var cat = InventoryDatabase.ItemSubtypes.FirstOrDefault(s => s.type_id == id);

            if (cat != null)
            {
                var catExist = InventoryDatabase.ItemSubtypes.FirstOrDefault(s => s.subtype == name);


                //Name already exist
                if (catExist != null)
                {
                    if (catExist.id == id)
                    {
                        return -1;
                    }
                    return -2;
                }

                cat.subtype = name;
            }
            InventoryDatabase.SaveChanges();
            return 1;
        }
    }
}