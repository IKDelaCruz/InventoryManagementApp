using InventoryManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Repository
{
    public class CompanyDepartmentRepository : BaseRepository
    {
        public List<CompanyViewModel> QueryCompanies()
        {
            var list = new List<CompanyViewModel>();

            var comp = InventoryDatabase.Companies.ToList();

            foreach (Company c in comp)
            {
                list.Add(new ViewModel.CompanyViewModel
                {
                    Id = c.id,
                    Name = c.name
                });
            }

            return list;
        }

        public CompanyViewModel QueryCompany(int id)
        {
            var comp = InventoryDatabase.Companies.FirstOrDefault(h => h.id == id);
            if (comp != null)
                return new CompanyViewModel
                {
                    Id = comp.id,
                    Name = comp.name
                };
            else
                return null;
        }
        public List<CompanyViewModel> QueryDepartments(int companyId)
        {
            var list = new List<CompanyViewModel>();

            var deps = InventoryDatabase.Departments.Where(h => h.company_id == companyId).ToList();

            foreach (Department d in deps)
            {
                list.Add(new CompanyViewModel
                {
                    Id = d.id,
                    Name = d.name,
                    ParentId = d.company_id
                });
            }

            return list;
        }
        public CompanyViewModel QueryDepartment(int id)
        {
            var dep = InventoryDatabase.Departments.FirstOrDefault(h => h.id == id);
            if (dep != null)
                return new CompanyViewModel
                {
                    Id = dep.id,
                    Name = dep.name
                };
            else
                return null;
        }

        public int CreateDepartment(string name)
        {
            var d = new Department { name = name, company_id = 0 };

            InventoryDatabase.Departments.Add(d);

            if (InventoryDatabase.SaveChanges() > 0)
                return d.id;
            return 0;
        }
    }
}
