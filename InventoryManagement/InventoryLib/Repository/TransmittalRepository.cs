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
                noted_by_id = newTrans.NotedById,

                transmitted_date = newTrans.TransmittedDate,
                transmitted_to_company_id = newTrans.TransmittedToCompanyId,
                transmitted_to_department_id = newTrans.TransmittedToDepartmentId,
                transmitted_to_user_id = newTrans.TransmittedToUserId
            };

            InventoryDatabase.transmitals.Add(trans);
            var result = InventoryDatabase.SaveChanges();
            if(result > 0)
            {
                foreach (TransmittalItemViewModel itm in newTrans.TransmittalItems)
                {
                    InventoryDatabase.transmittal_items.Add(new transmittal_items
                    {
                        item_id = itm.ItemId,
                        item_quantity = itm.Quantity,
                        transmittal_id = trans.transmital_id,
                    });
                    InventoryDatabase.SaveChanges();
                }
                return true;
            }

            return false;
        }
        public TransmittalViewModel GetTransmittalById(int id)
        {
            var trans = InventoryDatabase.vw_transmittal_details.FirstOrDefault(h => h.TransmittalId == id);
            if(trans != null)
            {

                var items = InventoryDatabase.vw_transmittal_items_details.Where(h => h.TransmittalId == id);
                var list = new List<TransmittalItemViewModel>();
                foreach(vw_transmittal_items_details it in items)
                {
                    list.Add(new TransmittalItemViewModel {
                     
                        ItemId = it.ItemId ?? 0,
                        Quantity = 1,
                        TransmittalId = id,
                        Description = it.ItemName,
                        Serial = it.Serial,
                        AssetTag = it.AssetTag,
                        Type = it.ItemType,
                        SubType = it.ItemSubType
                    });
                }

                return new TransmittalViewModel {
                    ApprovedBy = trans.ApprovedBy,
                    ApprovedDate = trans.CreatedDate ?? DateTime.MinValue,
                    CreatedDate = trans.CreatedDate ?? DateTime.MinValue,
                    PreparedBy = trans.PreparedBy,
                    NotedBy = trans.NotedBy,
                    TransmittedDate = trans.CreatedDate ?? DateTime.MinValue,
                    TransmittedToCompany = trans.Company,
                    TransmittedToDepartment = trans.Department,
                    TransmittedToUser = trans.Receiver,
                    TransmittalItems = list
                };
            }
            return null;
        }

        public List<TransmittalViewModel> GetTransmittals()
        {
            var list = new List<TransmittalViewModel>();
            var trans = InventoryDatabase.vw_transmittal_details.OrderByDescending(h=>h.CreatedDate).ToList();
            foreach(vw_transmittal_details t in trans)
            {
                list.Add(new TransmittalViewModel
                {
                    ApprovedBy = t.ApprovedBy,
                    ApprovedDate = t.CreatedDate ?? DateTime.MinValue,
                    CreatedDate = t.CreatedDate ?? DateTime.MinValue,
                    Id = t.TransmittalId,
                    PreparedBy = t.PreparedBy,
                    TransmittedDate = t.CreatedDate ?? DateTime.MinValue,
                    TransmittedToCompany = t.Company,
                    TransmittedToDepartment = t.Department,
                    TransmittedToUser = t.Receiver
                });
            }

            return list;
        }
    }
}
