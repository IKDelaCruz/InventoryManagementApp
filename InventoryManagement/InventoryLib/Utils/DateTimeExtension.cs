using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Utils
{
    public static class DateTimeExtension
    {
        public static string DateOnly(this DateTime dt)
        {
            return dt > DateTime.MinValue ? dt.ToString("MMM d, yyyy") : "";
        }
        public static string DateAndTime(this DateTime dt)
        {
            return dt > DateTime.MinValue ? dt.ToString("MMM d, yyyy hh:mm tt") : "";
       }
    }
}
