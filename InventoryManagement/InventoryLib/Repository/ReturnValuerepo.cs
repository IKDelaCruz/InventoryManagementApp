using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Repository
{
    public class ReturnValueRepo
    {
        public ReturnValueRepo()
        {
            Success = false;
        }
        public bool Success { get; set; }
        public string Message { get; set; }
        public string Param1 { get; set; }
        public string Param2 { get; set; }
    }
}
