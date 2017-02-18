using System.Collections.Generic;
using InventoryManagement.Repository;
using InventoryManagement.ViewModel;

namespace InventoryManagement.Model
{
    public class CategorySubcategoryModel : BaseModel
    {
        SubCategoryRepository subRepo;
        CategoryRepository catRepo;

        public CategorySubcategoryModel()
        {
            subRepo = new SubCategoryRepository();
            catRepo = new CategoryRepository();
        }

        public SubcategoryViewModel GetSubcategory(int id)
        {
            return subRepo.QuerySubcategory(id);
        }
        public List<SubcategoryViewModel> GetSubcategoriesByType(int categ)
        {
            return subRepo.GetSubcategoriesByType(categ);
        }
        public List<SubcategoryViewModel> QueryListSub()
        {
            return subRepo.QueryListofSub();
        }

        public List<SubcategoryViewModel> GetSubcategories()
        {
            return subRepo.QuerySubcategories();
        }

        public CategoryViewModel GetCategory(int id)
        {
            return catRepo.QueryCategory(id);
        }
        public List<CategoryViewModel> GetAllCategories()
        {
            return catRepo.QueryCategories();
        }




    }
    
}
