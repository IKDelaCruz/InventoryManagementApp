using InventoryManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Model
{
    public class TransactionModel : BaseModel
    {
        Repository.TransactionRepository tRepository;

        public TransactionModel()
        {
            tRepository = new Repository.TransactionRepository();
        }

        public bool InsertLog(int systemUserId, int otherUserId, TransactionType type, string remarks, int itemId = 0)
        {
            return tRepository.InsertTransaction(systemUserId, otherUserId, type, remarks, itemId);
        }

        public List<TransactionViewModel> GetTransactionsByItemId(int id)
        {
            return tRepository.GetTransactionsByItemId(id);
        }
        public List<TransactionViewModel> GetTransactions()
        {
            return tRepository.GetTransactions();
        }
    }
}
