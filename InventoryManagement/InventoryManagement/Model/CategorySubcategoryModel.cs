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

        public CategorySubcategoryModel()
        {
            csR = new CategorySubcategoryRepository();
        }
        public CategorySubcategoryViewModel GetCategory(int id)
        {
            return csR.QueryCategory(id);
        }
        public List<CategorySubcategoryViewModel> GetCategories()
        {
            return csR.QueryCategories();
        }
      
    }
}
