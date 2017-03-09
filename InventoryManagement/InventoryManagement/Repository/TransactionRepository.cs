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

            var trans= InventoryDatabase.transacitons.Where(x=> x.transaction_system_user_id == id).ToList();
            foreach(transaciton t in trans)
            {
                list.Add(new ViewModel.TransactionViewModel {
                    Id = t.transaction_id,
                    OtherUserId = t.transaction_other_user_id,
                    Remarks = t.transaction_remarks,
                    SystemUserId = t.transaction_system_user_id,
                    TransactionDate = t.transaction_date,
                    TransactionTypeId = t.transaction_type_id
                });
            }

            return list;
        }

        public List<TransactionViewModel> GetTransactionsByItemId(int id)
        {
            var list = new List<TransactionViewModel>();

            var trans = InventoryDatabase.vw_item_log.Where(x => x.ItemId == id).OrderBy(x=> x.TransactionDate).ToList();
            foreach (vw_item_log t in trans)
            {
                list.Add(new ViewModel.TransactionViewModel
                {
                    Id = t.TransactionId,
                    OtherUserName= t.OtherUserFirstname + " " + t.OtherUserLastname,
                    SystemUserName = t.SystemFirstname + " " + t.SystemLastname,
                    TransactionDate = t.TransactionDate,
                    TransactionTypeId = t.TransactionTypeId,
                    ItemId = t.ItemId ?? 0,
                    ItemName = t.ItemName,


                });
            }

            return list;
        }

        public List<TransactionViewModel> GetTransactions()
        {
            var list = new List<TransactionViewModel>();

            var trans = InventoryDatabase.vw_transaction_summary.ToList();
            foreach (vw_transaction_summary t in trans)
            {
                list.Add(new ViewModel.TransactionViewModel
                {
                    SystemUserName = t.SystemUser,
                    SystemUserId = t.SystemUserId,
                    TransactionDate = t.TranscationDate,
                    TransactionTypeId = t.TransactionTypeId,
                    TransactionType = t.TransactionType,
                    OtherUserId = t.CustomerUserId,
                    OtherUserName = t.CustomerUser,
                    ItemName = t.ItemName,
                    Id = t.TransactionId
                });
            }

            return list;
        }

        public bool InsertTransaction(int systemUserIdm, int otherUserId, int transactionType, string remarks, int itemId = 0)
        {
             InventoryDatabase.transacitons.Add(new Repository.transaciton {
                transaction_other_user_id = otherUserId,
                transaction_remarks = remarks,
                transaction_system_user_id = systemUserIdm,
                transaction_date = DateTime.Now,
                transaction_type_id = (int)transactionType,
                transaction_item_id = itemId,
                transaction_request_id = 0
                
                
             });

            var result = InventoryDatabase.SaveChanges();

            return result > 0;
        }
    }
}
