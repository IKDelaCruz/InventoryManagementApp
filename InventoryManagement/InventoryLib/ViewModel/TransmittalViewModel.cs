using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLib.ViewModel
{
    public class TransmittalViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ApprovedDate { get; set; }
        public DateTime TransmittedDate { get; set; }
        public int TransmittedToUserId { get; set; }
        public int TransmittedToCompanyId { get; set; }
        public int TransmittedToDepartmentId { get; set; }
        public int ApprovedById { get; set; }
        public int PreparedById { get; set; }
    }
}
