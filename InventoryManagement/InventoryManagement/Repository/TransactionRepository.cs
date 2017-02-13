using InventoryManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Repository
{
    public class TransactionRepository : BaseRepository
    {
        public List<TransactionViewModel> GetTransactionsBySystemUserId (int id)
        {
            var list = new List<TransactionViewModel>();

            var trans= InventoryDatabase.Transactions.Where(x=> x.system_user_id == id).ToList();
            foreach(Transaction t in trans)
            {
                list.Add(new ViewModel.TransactionViewModel {
                    Id = t.id,
                    OtherUserId = t.other_user_id,
                    Remarks = t.remarks,
                    SystemUserId = t.system_user_id,
                    TransactionDate = t.transaction_date,
                    TransactionTypeId = (TransactionType)t.transaction_type_id
                });
            }

            return list;
        }

        public List<TransactionViewModel> GetTransactionsByItemId(int id)
        {
            var list = new List<TransactionViewModel>();

            var trans = InventoryDatabase.vwItemLogs.Where(x => x.ItemId == id).OrderBy(x=> x.TransactionDate).ToList();
            foreach (vwItemLog t in trans)
            {
                list.Add(new ViewModel.TransactionViewModel
                {
                    Id = t.TransactionId,
                    OtherUserName= t.OtherUserFirstname + " " + t.OtherUserLastname,
                    SystemUserName = t.SystemFirstname + " " + t.SystemLastname,
                    TransactionDate = t.TransactionDate,
                    TransactionTypeId = (TransactionType)t.TransactionTypeId,
                    ItemId = t.ItemId ?? 0,
                    ItemName = t.ItemName,


                });
            }

            return list;
        }

        public List<TransactionViewModel> GetTransactions()
        {
            var list = new List<TransactionViewModel>();

            var trans = InventoryDatabase.Transactions.ToList();
            foreach (Transaction t in trans)
            {
                list.Add(new ViewModel.TransactionViewModel
                {
                    //Id = t.id,
                    //OtherUserId = t.other_user_id,
                    //Remarks = t.remarks,
                    SystemUserId = t.system_user_id,
                    TransactionDate = t.transaction_date,
                    TransactionTypeId = (TransactionType)t.transaction_type_id


                });
            }

            return list;
        }

        public bool InsertTransaction(int systemUserIdm, int otherUserId, TransactionType transactionType, string remarks, int itemId = 0)
        {
             InventoryDatabase.Transactions.Add(new Repository.Transaction {
                other_user_id = otherUserId,
                remarks = remarks,
                system_user_id = systemUserIdm,
                transaction_date = DateTime.Now,
                transaction_type_id = (int)transactionType,
                item_id = itemId
             });

            var result = InventoryDatabase.SaveChanges();

            return result > 0;
        }
    }
}
