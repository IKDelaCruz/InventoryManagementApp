using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.ViewModel
{
     public class SubcategoryViewModel
    {
        public int Sub_Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Prefix { get; set; }

    }
}
