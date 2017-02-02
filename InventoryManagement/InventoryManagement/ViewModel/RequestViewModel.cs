using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.ViewModel
{
    public enum RequestType
    {
        Borrow,
        Return,
        Reserve,
        Repair,
        Dispose
    }
    public enum RequestStatus
    {
        New,
        Approved,
        Delivered,
        Declined,
        Deleted,
    }

    public class RequestViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserFullnameEmail { get; set; }
        public RequestType RequestType { get; set; }
        public PrimaryItemType RequestItemPrimaryType { get; set; }
        public SecondaryItemType RequestSecondaryItemType { get; set; }
        public int RequestedById { get; set; }
        public int ProcessedById { get; set; }
        public DateTime NeededDate { get; set; }
        public DateTime RequestedDate { get; set; }
        public DateTime ProcessDate { get; set; }
        public RequestStatus RequestedStatus { get; set; }

        public string Remarks { get; set; }
        public string AdminRemarks { get; set; }
    }
}

