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
        public List<CompanyDepartmentViewModel> QueryCompanies()
        {
            var list = new List<CompanyDepartmentViewModel>();

            var comp = Database.Companies.ToList();

            foreach (Company c in comp)
            {
                list.Add(new ViewModel.CompanyDepartmentViewModel
                {
                    Id = c.id,
                    Name = c.name
                });
            }

            return list;
        }

        public CompanyDepartmentViewModel QueryCompany(int id)
        {
            var comp = Database.Companies.FirstOrDefault(h => h.id == id);
            if (comp != null)
                return new CompanyDepartmentViewModel
                {
                    Id = comp.id,
                    Name = comp.name
                };
            else
                return null;
        }
        public List<CompanyDepartmentViewModel> QueryDepartments(int companyId)
        {
            var list = new List<CompanyDepartmentViewModel>();

            var deps = Database.Departments.Where(h => h.company_id == companyId).ToList();

            foreach (Department d in deps)
            {
                list.Add(new CompanyDepartmentViewModel
                {
                    Id = d.id,
                    Name = d.name,
                    ParentId = d.company_id
                });
            }

            return list;
        }
        public CompanyDepartmentViewModel QueryDepartment(int id)
        {
            var dep = Database.Departments.FirstOrDefault(h => h.id == id);
            if (dep != null)
                return new CompanyDepartmentViewModel
                {
                    Id = dep.id,
                    Name = dep.name
                };
            else
                return null;
        }
    }
}
