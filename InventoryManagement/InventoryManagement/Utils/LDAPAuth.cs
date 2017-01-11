using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;

namespace InventoryManagement.Utils
{
    public class LdapAuth
    {
        public static bool IsInRole(string domain, string username, string password, string role)
        {
            using (var context = new PrincipalContext(ContextType.Domain, domain, username, password))
            {
                try
                {
                    GroupPrincipal group = GroupPrincipal.FindByIdentity(context, IdentityType.SamAccountName, role);
                    UserPrincipal user = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, username);
                    return IsInGroup(user, group);
                }
                catch (Exception ex)
                {
                    ErrorLogger.LogException(ex);
                    return false;
                }
                
            }
        }

        public static bool IsInGroup(Principal principal, GroupPrincipal group)
        {
            if (principal.IsMemberOf(group))
                return true;

            foreach (var g in principal.GetGroups())
            {
                if (IsInGroup(g, group))
                    return true;
            }

            return false;
        }
    }
}
