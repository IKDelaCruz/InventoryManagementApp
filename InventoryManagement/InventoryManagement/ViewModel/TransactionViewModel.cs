using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.ViewModel
{
    public enum TransactionType
    {
        Login = 1,
        Logout,
        CreateItem,
        EditItem,
        DeleteItem,
        BorrowItem,
        ReserveItem,
        ReturnItem,
        RepairItem,
        DisposeItem,
        CreateUser,
        EditUser,
        DeleteUser,
        DeliverRequest,
        AssignItem
    }

    public class TransactionViewModel
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionDateString { get; set; }
        public int SystemUserId { get; set; }
        public string SystemUserName { get; set; }
        public int OtherUserId { get; set; }
        public string OtherUserName { get; set; }
        public int TransactionTypeId { get; set; }
        public string TransactionType { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string Remarks { get; set; }
    }
}
