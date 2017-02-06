using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagement.Repository;
using InventoryManagement.ViewModel;
using System.Collections.Generic;

namespace InventoryManagement.Model
{
    public class CategorySubcategoryModel : BaseModel
    {
        CategorySubcategoryRepository csR;
        CategoryRepository cR;

        public CategorySubcategoryModel()
        {
            csR = new CategorySubcategoryRepository();
            cR = new CategoryRepository();
        }

        public SubcategoryViewModel GetSubcategory(int id)
        {
            return csR.QuerySubcategory(id);
        }
        public List<SubcategoryViewModel> GetSubcategoriesByType(int categ)
        {
            return csR.GetSubcategoriesByType(categ);
        }
        //public CategoryViewModel SaveItemType(int id)
        //{
        //    //return csR.CreateCategorySubcategory(id);
        //}



    }
    
}
