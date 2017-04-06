using InventoryLib.ViewModel;
using InventoryManagement.Repository;
using InventoryManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLib.Repository
{
    class TransmittalRepository : BaseRepository
    {
        public bool InsertTransmittal(TransmittalViewModel newTrans )
        {
            var trans = new transmital {
                approved_by_id = newTrans.ApprovedById,
                approved_date = newTrans.ApprovedDate,
                created_date = newTrans.CreatedDate,
                prepared_by_id = newTrans.PreparedById,
                transmitted_date = newTrans.TransmittedDate,
                transmitted_to_company_id = newTrans.TransmittedToCompanyId,
                transmitted_to_department_id = newTrans.TransmittedToDepartmentId,
                transmitted_to_user_id = newTrans.TransmittedToUserId
            };

            InventoryDatabase.transmitals.Add(trans);
            InventoryDatabase.SaveChanges();
            return true;
        }
        public TransmittalViewModel GetTransmittalById(int id)
        {
            var trans = InventoryDatabase.transmitals.FirstOrDefault(h => h.transmital_id == id);
            if(trans != null)
            {
                return new TransmittalViewModel {
                    ApprovedById = trans.approved_by_id,
                    ApprovedDate = trans.approved_date ?? DateTime.MinValue,
                    CreatedDate = trans.created_date ?? DateTime.MinValue,
                    PreparedById = trans.prepared_by_id,
                    TransmittedDate = trans.transmitted_date,
                    TransmittedToCompanyId = trans.transmitted_to_company_id,
                    TransmittedToDepartmentId = trans.transmitted_to_department_id,
                    TransmittedToUserId = trans.transmitted_to_user_id
                };
            }
            return null;
        }
        public List<TransmittalViewModel> GetTransmittals()
        {
            var list = new List<TransmittalViewModel>();
            var trans = InventoryDatabase.transmitals.ToList();
            foreach(transmital t in trans)
            {
                list.Add(new TransmittalViewModel
                {
                    ApprovedById = t.approved_by_id,
                    ApprovedDate = t.approved_date ?? DateTime.MinValue,
                    CreatedDate = t.created_date ?? DateTime.MinValue,
                    Id = t.transmital_id,
                    PreparedById = t.prepared_by_id,
                    TransmittedDate = t.transmitted_date,
                    TransmittedToCompanyId = t.transmitted_to_company_id,
                    TransmittedToDepartmentId = t.transmitted_to_department_id,
                    TransmittedToUserId = t.transmitted_to_user_id
                });
            }

            return list;
        }
    }
}
