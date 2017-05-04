using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class HtmlGenerator
    {
        public static string GenerateItemHtml(string description, string serial, string quantity, string unit)
        {
            var template = @"
            <div class='row row-right row-left'>
                <div class='col-5 detail'> ItemDescription </div>
                <div class='col-5 detail'> ItemSerial </div>
                <div class='col-1 detail text-center'> ItemQuantity </div>
                <div class='col-1 detail text-center'> ItemUnit </div>
            </div>";

            var result = template.Replace("ItemDescription", description);
            result = result.Replace("ItemSerial", serial);
            result = result.Replace("ItemQuantity", quantity);
            result = result.Replace("ItemUnit", unit);

            return result;
        }
    }
}
