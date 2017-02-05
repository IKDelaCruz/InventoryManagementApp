using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagement.ViewModel;


namespace InventoryManagement.Repository
{
    public class CategorySubcategoryRepository : BaseRepository
    {



        public List<SubcategoryViewModel> GetSubcategoriesByType(int categ)
        {
            var list = new List<SubcategoryViewModel>();

            var sub = InventoryDatabase.ItemSubtypes.Where(x => x.type_id == categ).ToList();
            foreach (ItemSubtype s in sub)
            {
                list.Add(new ViewModel.SubcategoryViewModel
                {
                    id = s.id,
                    subcategory = s.subtype,
                    prefix = s.prefix
                    
                });
            }

            return list;
        }

        public SubcategoryViewModel QuerySubcategory(int id)
        {
            var categ = InventoryDatabase.ItemSubtypes.FirstOrDefault(h => h.id == id);
            if (categ != null)
                return new ViewModel.SubcategoryViewModel
                {
                    id = categ.id,
                    subcategory = categ.subtype,


                };
            else
                return null;
        }


        //public int CreateCategorySubcategory(string type)
        //{
        //    var c = new ItemType { type = type };

        //    InventoryDatabase.ItemTypes.Add(c);

        //    if (InventoryDatabase.SaveChanges() > 0)
        //        return c.id;
        //    return 0;
        //}

        public bool UpdateItemType(int id, string type)
        {
            var categ = InventoryDatabase.ItemTypes.FirstOrDefault(h => h.id == id);
            if (categ != null)
            {
                categ.type = type;
       
                InventoryDatabase.SaveChanges();

                return true;
            }

            return false;
        }



        public int CreateNewType(string type)
        {

            ItemType newType = new ItemType
            {
                type = type
            };
            InventoryDatabase.ItemTypes.Add(newType);
            try
            {
                InventoryDatabase.SaveChanges();
                return newType.id;
            }
            catch
            {
                return 0;
            }


        }
    }
}