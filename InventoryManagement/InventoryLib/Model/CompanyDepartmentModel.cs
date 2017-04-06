using InventoryManagement.Repository;
using InventoryManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Model
{
    public class CompanyDepartmentModel : BaseModel
    {
        CompanyDepartmentRepository cdR;
        public CompanyDepartmentModel()
        {
            cdR = new CompanyDepartmentRepository();
        }
        public CompanyViewModel GetCompany(int id)
        {
            return cdR.QueryCompany(id);
        }
        public List<CompanyViewModel> GetCompanies()
        {
            return cdR.QueryCompanies();
        }
        public CompanyViewModel GetDepartment(int id)
        {
            return cdR.QueryDepartment(id);
        }

        public CompanyViewModel GetDepartment(string name)
        {
            return cdR.QueryDepartment(name);
        }

        public List<CompanyViewModel> GetDepartments(int companyId)
        {
            return cdR.QueryDepartments(companyId);
        }
        public List<CompanyViewModel> GetCompaniesWithDepartments()
        {
            var list = new List<CompanyViewModel>();

            var comps = cdR.QueryCompanies();

            foreach(CompanyViewModel c in comps)
            {
                var deps = cdR.QueryDepartments(c.Id);
                foreach(CompanyViewModel d in deps)
                {
                    list.Add(new CompanyViewModel {
                        Id = d.Id,
                        Name = c.Name + " - " + d.Name
                    });
                }
            }

            return list;
        }

        public int CreateDepartment(string name)
        {
            return cdR.CreateDepartment(name);
        }
    }
}
