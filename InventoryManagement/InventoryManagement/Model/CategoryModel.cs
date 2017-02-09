using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagement.Model;
using InventoryManagement.ViewModel;
using InventoryManagement.Repository;

namespace InventoryManagement.Model
{
    public class CategoryModel
    {

        CategoryRepository cR;

        public CategoryModel()
        {
            cR = new CategoryRepository();
        }
        public CategoryViewModel GetCategory(int id)
        {
            return cR.QueryCategory(id);
        }
        public List<CategoryViewModel> GetCategories()
        {
            return cR.QueryCategories();
        }


        public int CreateType(string type)
        {
            return cR.Create(type);
        }

        public int Update(int id, string type)
        {
            return cR.Update(id, type);
        }
    }
}
