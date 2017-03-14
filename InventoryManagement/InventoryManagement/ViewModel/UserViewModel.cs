using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.ViewModel
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }
        public string LastnameFirstName { get; set; }
        public string LastnameFirstNameUsername { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Department { get; set; }
        public string Company { get; set; }
        public int DepartmentId { get; set; }
        public int CompanyId { get; set; }
    }
}

