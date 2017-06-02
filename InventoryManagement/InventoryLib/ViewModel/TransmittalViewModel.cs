using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLib.ViewModel
{
    public class TransmittalViewModel
    {
        public TransmittalViewModel()
        {
            TransmittalItems = new List<TransmittalItemViewModel>();
        }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ApprovedDate { get; set; }
        public DateTime TransmittedDate { get; set; }
        public int TransmittedToUserId { get; set; }
        public string TransmittedToUser { get; set; }
        public int TransmittedToCompanyId { get; set; }
        public string TransmittedToCompany { get; set; }
        public int TransmittedToDepartmentId { get; set; }
        public string TransmittedToDepartment { get; set; }
        public int ApprovedById { get; set; }

        public string ApprovedBy { get; set; }
        public int PreparedById { get; set; }
        public string PreparedBy { get; set; }
        public int NotedById { get; set; }
        public string NotedBy { get; set; }

        public string Purpose { get; set; }

        public List<TransmittalItemViewModel> TransmittalItems { get; set; }
    }
    public class TransmittalItemViewModel
    {
        public int Id { get; set; }
        public int TransmittalId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Serial { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public string AssetTag { get; set; }
    }
}
