using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Model
{
    public class ReturnValueModel
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string Param1 { get; set; }
        public string Param2 { get; set; }
    }
}
