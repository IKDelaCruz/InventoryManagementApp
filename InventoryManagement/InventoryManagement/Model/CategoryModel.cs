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
        //SubCategoryRepository Sr; // <--- eto yung nag eerror pauiee, di niya marecognize yung repo na to
        // dahil ata di pwedeng dalawang repo  sa bawat isang model, so nilagay ko na lang sya sa cR and it worked.
        CategoryRepository cR;

        public CategoryModel()
        {
            cR = new CategoryRepository();
        }
        public CategoryViewModel GetItemTypeName(string name)
        {
            return cR.GetItemTypebyName(name);
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

        public int CreateSubtype(int id, string type)
        {
            return cR.CreateSubCateg(id, type);
        }

        public int UpdateSubtype(int id, string type)
        {
            return cR.UpdateSubCateg(id, type);
        }

    }
}
