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

        public List <CategorySubcategoryViewModel> QueryCompanies()
        {
            var list = new List<CategorySubcategoryViewModel>();

            var categ = InventoryDatabase.Category.ToList();

            foreach (Category c in categ)
            {
                list.Add(new ViewModel.CategorySubcategoryViewModel

                {
                    Id = c.id,
                    Name = c.type,
                    subcategory = c.subtype
                });
            }

            return list;

        }
    }
}
