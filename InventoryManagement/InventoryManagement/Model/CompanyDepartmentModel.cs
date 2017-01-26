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
        public CompanyDepartmentViewModel GetCompany(int id)
        {
            return cdR.QueryCompany(id);
        }
        public List<CompanyDepartmentViewModel> GetCompanies()
        {
            return cdR.QueryCompanies();
        }
        public CompanyDepartmentViewModel GetDepartment(int id)
        {
            return cdR.QueryDepartment(id);
        }
        public List<CompanyDepartmentViewModel> GetDepartments(int companyId)
        {
            return cdR.QueryDepartments(companyId);
        }
        public List<CompanyDepartmentViewModel> GetCompaniesWithDepartments()
        {
            var list = new List<CompanyDepartmentViewModel>();

            var comps = cdR.QueryCompanies();

            foreach(CompanyDepartmentViewModel c in comps)
            {
                var deps = cdR.QueryDepartments(c.Id);
                foreach(CompanyDepartmentViewModel d in deps)
                {
                    list.Add(new CompanyDepartmentViewModel {
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
