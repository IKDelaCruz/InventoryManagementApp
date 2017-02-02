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
            var s = new LDAPManager().GetOrganizationalUnits();
            

            foreach(LDAPGroupInformation l in s)
            {
                int departmentId = Singleton.Instance.CompanyDepartmentModel.CreateDepartment(l.Name);
                if(departmentId > 0)
                {
                    foreach(LDAPUserInformation ui in l.Members)
                    {
                        var existing = Singleton.Instance.UserModel.GetUsersByUsername(ui.Username);
                        if(existing == null)
                            Singleton.Instance.UserModel.CreateNewUser(ui.Username, "", UserModel.UserType.User, ui.Firstname, ui.Lastname, departmentId);
                    }
                }
            }
        }
    }
}
