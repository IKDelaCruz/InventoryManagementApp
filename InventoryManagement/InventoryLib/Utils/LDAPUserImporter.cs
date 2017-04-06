using AuthenticationLibrary;
using InventoryManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Utils
{
    public class LDAPUserImporter
    {
         public void ImportLDAPUser()
        {
            var s = new LDAPManager().SyncOrganizationalUnits();
            

            foreach(LDAPGroupInformation l in s)
            {
                int departmentId = 0;
                var existingDept = Singleton.Instance.CompanyDepartmentModel.GetDepartment(l.Name);
                if (existingDept != null)
                    departmentId = existingDept.Id;
                else
                    departmentId = Singleton.Instance.CompanyDepartmentModel.CreateDepartment(l.Name);

                if (departmentId > 0)
                {
                    foreach(LDAPUserInformation ui in l.Members)
                    {
                        var existing = Singleton.Instance.UserModel.GetUsersByUsername(ui.Username);
                        var userType = ui.IsAdministrator ? UserModel.UserType.Admin : UserModel.UserType.User;
                        if (existing == null)
                        {
                            Singleton.Instance.UserModel.CreateNewUser(ui.Username, "", userType, ui.Firstname, ui.Lastname, departmentId, ui.Gender == "M", ui.Disabled);
                        }
                        else
                        {
                            Singleton.Instance.UserModel.UpdateUser(existing.Id,  ui.Firstname, ui.Lastname, departmentId, userType, "", ui.Disabled);
                        }
                    }
                }
            }
        }
    }
}
