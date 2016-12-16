using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.ViewModel
{
    public class CompanyDepartmentViewModel
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
    }
}
