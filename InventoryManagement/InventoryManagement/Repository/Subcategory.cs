using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagement.ViewModel;


namespace InventoryManagement.Repository
{
    public class SubCategoryRepository : BaseRepository
    {

        public List<SubcategoryViewModel> GetSubcategoriesByType(int categoryId)
        {
            var list = new List<SubcategoryViewModel>();

            var sub = InventoryDatabase.ItemSubtypes.Where(x => x.type_id == categoryId).ToList();
            foreach (ItemSubtype s in sub)
            {
                list.Add(new ViewModel.SubcategoryViewModel
                {
                    Sub_Id = s.id,
                    CategoryId = s.type_id,
                    Name = s.subtype,
                   
                    
                });
            }

            return list;
        }

        public List<SubcategoryViewModel> QuerySubcategories()
        {
            var subtypes = InventoryDatabase.ItemSubtypes.ToList();
            List<SubcategoryViewModel> bList = new List<SubcategoryViewModel>();

            foreach (ItemSubtype s in subtypes)
            {
                bList.Add(new SubcategoryViewModel { Sub_Id = s.id, Name = s.subtype });
            }
            return bList;
        }

        public SubcategoryViewModel QuerySubcategory(int id)
        {
            var categ = InventoryDatabase.ItemSubtypes.FirstOrDefault(h => h.id == id);
            if (categ != null)
                return new ViewModel.SubcategoryViewModel
                {
                    Sub_Id = categ.id,
                    Name = categ.subtype,


                };
            else
                return null;
        }

        public List<SubcategoryViewModel> QueryListofSub()
        {
            var sublist = new List<SubcategoryViewModel>();
            var sub = InventoryDatabase.ItemSubtypes.ToList();

            //var categ = categ1.GroupBy(i => i.id).Select(group => group.First());

            //List<CategorySubcategoryViewModel> cList = new List<CategorySubcategoryViewModel>();

            foreach (ItemSubtype s in sub)
            {

                sublist.Add(new SubcategoryViewModel

                {
                    Sub_Id = s.id,
                    CategoryId = s.type_id,
                    Name = s.subtype,

                });
                //subcategory = c.subtype 

            }
            return sublist;

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
