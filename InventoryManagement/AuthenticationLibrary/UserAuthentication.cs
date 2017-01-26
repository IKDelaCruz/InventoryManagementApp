using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationLibrary
{
    public class LDAPUserInformation
    {
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Department { get; set; }
    }
    public class LDAPGroupInformation
    {
        public string Name { get; set; }
        public List<LDAPUserInformation> Members { get; set; }
    }
    public class LDAPManager
    {
        public bool AuthenticateLDAP(string username, string password)
        {
            return true;
        }
        public List<LDAPUserInformation> GetLDAPUsers(string OU)
        {
            var list = new List<LDAPUserInformation>();

            using (var context = new PrincipalContext(ContextType.Domain, "jakagroup.com", OU))
            {
                using (var searcher = new PrincipalSearcher(new UserPrincipal(context)))
                {

                    foreach (var result in searcher.FindAll())
                    {
                        DirectoryEntry de = result.GetUnderlyingObject() as DirectoryEntry;

                        var item = new LDAPUserInformation
                        {
                            Firstname = (de.Properties["givenName"].Value) == null ? "" : (de.Properties["givenName"].Value).ToString(),
                            Lastname = de.Properties["sn"].Value == null ? "" : (de.Properties["sn"].Value).ToString(),
                            Username = de.Properties["samAccountName"].Value == null ? "" : (de.Properties["samAccountName"].Value).ToString(),
                            Department = OU
                        };
                      
                        list.Add(item);



                    }
                }
            }


            return list;
        }


        public List<LDAPGroupInformation> GetOrganizationalUnits()
        {
            List<LDAPGroupInformation> orgUnits = new List<LDAPGroupInformation>();

            DirectoryEntry startingPoint = new DirectoryEntry("LDAP://DC=Jakagroup,DC=com");

            DirectorySearcher searcher = new DirectorySearcher(startingPoint);
            searcher.Filter = "(objectCategory=organizationalUnit)";

            foreach (SearchResult res in searcher.FindAll())
            {
                var ldapGroup = new LDAPGroupInformation { Name = res.Properties["name"][0].ToString() };
                if (ldapGroup.Name.IndexOf("-") > -1)
                {
                    ldapGroup.Members = GetLDAPUsers(res.Path.ToString().Replace("LDAP://", ""));
                    orgUnits.Add(ldapGroup);
                    
                }
            }
            return orgUnits.OrderBy(x => x.Name).ToList();
        }

        
    }
}
