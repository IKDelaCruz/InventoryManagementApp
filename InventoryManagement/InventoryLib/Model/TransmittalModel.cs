using InventoryLib.Repository;
using InventoryLib.ViewModel;
using InventoryManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLib.Model
{
    public class TransmittalModel : BaseModel
    {
        TransmittalRepository repo;
        public TransmittalModel()
        {
            repo = new TransmittalRepository();
        }
        public bool InsertTransmittal(TransmittalViewModel newTrans)
        {
            return repo.InsertTransmittal(newTrans);
        }
        public TransmittalViewModel GetTransmittalById(int id)
        {
            return repo.GetTransmittalById(id);
        }
        public List<TransmittalViewModel> GetTransmittals()
        {
            return repo.GetTransmittals();
        }
    }
}
