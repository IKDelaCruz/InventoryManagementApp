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

        public List <CategorySubcategoryViewModel> QueryCategories()
        {
            //var list = new List<CategorySubcategoryViewModel>();
            var categ = InventoryDatabase.Categories.ToList();
            List<CategorySubcategoryViewModel> cList = new List<CategorySubcategoryViewModel>();

            foreach (Category c in categ)
            {
                cList.Add(new CategorySubcategoryViewModel

                {
                    id = c.id,
                    category = c.type,
                    //subcategory = c.subtype
                });
            }

            return cList;

        }

        public CategorySubcategoryViewModel QueryCategory(int id)
        {
            var categ = InventoryDatabase.Categories.FirstOrDefault(h => h.id == id);
            if (categ != null)
                return new CategorySubcategoryViewModel
                {
                    id = categ.id,
                    category = categ.type,
                    subcategory = categ.subtype
                };
            else
                return null;
        }

        public int CreateCategorySubcategory(string type, string subtype, string prefix)
        {
            var c = new Category { type = type, subtype = subtype, prefix = prefix };

            InventoryDatabase.Categories.Add(c);

            if (InventoryDatabase.SaveChanges() > 0)
                return c.id;
            return 0;
        }

    }
}
