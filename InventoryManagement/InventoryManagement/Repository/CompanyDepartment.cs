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

            var comp = InventoryDatabase.companies.ToList();

            foreach (company c in comp)
            {
                list.Add(new ViewModel.CompanyViewModel
                {
                    Id = c.company_id,
                    Name = c.company_name
                });
            }

            return list;
        }

        public CompanyViewModel QueryCompany(int id)
        {
            var comp = InventoryDatabase.companies.FirstOrDefault(h => h.company_id == id);
            if (comp != null)
                return new CompanyViewModel
                {
                    Id = comp.company_id,
                    Name = comp.company_name
                };
            else
                return null;
        }
        public List<CompanyViewModel> QueryDepartments(int companyId)
        {
            var list = new List<CompanyViewModel>();

            var deps = InventoryDatabase.departments.Where(h => h.department_company_id == companyId).ToList();

            foreach (department d in deps)
            {
                list.Add(new CompanyViewModel
                {
                    Id = d. department_id,
                    Name = d.department_name,
                    ParentId = d.department_company_id
                });
            }

            return list;
        }
        public CompanyViewModel QueryDepartment(int id)
        {
            var dep = InventoryDatabase.departments.FirstOrDefault(h => h.department_id == id);
            if (dep != null)
                return new CompanyViewModel
                {
                    Id = dep.department_company_id,
                    Name = dep.department_name
                };
            else
                return null;
        }
        public CompanyViewModel QueryDepartment(string name)
        {
            var dep = InventoryDatabase.departments.FirstOrDefault(h => h.department_name == name);
            if (dep != null)
                return new CompanyViewModel
                {
                    Id = dep.department_company_id,
                    Name = dep.department_name
                };
            else
                return null;
        }
        public int CreateDepartment(string name)
        {
            var d = new department { department_name = name, department_company_id = 0 };

            InventoryDatabase.departments.Add(d);

            if (InventoryDatabase.SaveChanges() > 0)
                return d.department_id;
            return 0;
        }
    }
}
