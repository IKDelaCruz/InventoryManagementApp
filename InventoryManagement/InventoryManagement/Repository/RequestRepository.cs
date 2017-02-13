using InventoryManagement.ViewModel;
using InventoryManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagement.Utils;

namespace InventoryManagement.Repository
{
    public class RequestRepository : BaseRepository
    {
        public int InsertNewRequest(RequestViewModel req)
        {

            //request.RequestedDate = DateTime.Now;
            //request.RequestType = (RequestType)cbxRequestType.SelectedItem;
            //request.RequestedStatus = RequestStatus.New;
            //request.RequestItemType = (PrimaryItemType)cbxType.SelectedItem;
            //request.RequestSecondaryItemType = (SecondaryItemType)cbxSubType.SelectedItem;
            //request.NeededDate = dtpNeededDate.Value;
            //request.UserId = (int)cbxUsers.SelectedValue;
            //request.Remarks = txtRemarks.ToString();


            var newReq = new Request
            {
                request_date = req.RequestedDate,
                requested_by_id = req.RequestedById,
                request_item_primary_type = (int)req.RequestItemPrimaryType,
                request_item_secondary_type = (int)req.RequestSecondaryItemType,
                subtype = req.Subtype,
                request_status = (int)req.RequestedStatus,
                user_id = req.UserId,
                request_type = (int)req.RequestType,
                need_date = req.NeededDate,
                remarks = req.Remarks,
                admin_remarks =req.AdminRemarks
            };
            InventoryDatabase.Requests.Add(newReq);
            if (InventoryDatabase.SaveChanges() > 0)
                return newReq.id;
            else
                return 0;
        }
        public List<RequestViewModel> GetRequestByUserId(int userId)
        {        
            var result = new List<RequestViewModel>();
            var reqs = InventoryDatabase.Requests.Where(x => x.user_id == userId);
            foreach (Request r in reqs)
            {
                result.Add(new RequestViewModel
                {
                    Id = r.id,
                    ProcessDate = r.process_date ?? DateTime.MinValue,
                    ProcessedById = r.process_by_id ?? 0,
                    RequestedById = r.requested_by_id,
                    RequestedDate = r.request_date,
                    RequestedStatus = (RequestStatus)r.request_status,
                    RequestItemPrimaryType = (int)r.request_item_primary_type,
                    RequestSecondaryItemType = (int)r.request_item_secondary_type,
                    RequestType = (RequestType)r.request_type,
                    Remarks = r.remarks,
                    UserId = r.user_id,
                    AdminRemarks = r.admin_remarks
                });
            }
            return result;
        }
        public List<RequestViewModel> GetRequestByStatus(RequestStatus status)
        {
            var result = new List<RequestViewModel>();
            var reqs = InventoryDatabase.Requests.Where(x => x.request_status == (int)status);

            
            foreach (Request r in reqs)
            {
                result.Add(new RequestViewModel
                {
                    Id = r.id,
                    ProcessDate = r.process_date ?? DateTime.MinValue,
                    ProcessedById = r.process_by_id ?? 0,
                    RequestedById = r.requested_by_id,
                    RequestedDate = r.request_date,
                    RequestedStatus = (RequestStatus)r.request_status,
                    RequestItemPrimaryType = (int)r.request_item_primary_type,
                    RequestSecondaryItemType = (int)r.request_item_secondary_type,
                    Subtype = r.subtype,
                    RequestType = (RequestType)r.request_type,
                    Remarks = r.remarks,
                    UserId = r.user_id,
                    AdminRemarks = r.admin_remarks,
                    ExpectedReturnDate = r.expected_return_date ?? DateTime.MinValue,
                    NeededDate = r.need_date?? DateTime.MinValue,

                });
            }
            return result;
        }
        public RequestViewModel GetRequestById(int requestId)
        {
            var r = InventoryDatabase.Requests.FirstOrDefault(x => x.id == requestId);
            var result = new RequestViewModel
            {
                Id = r.id,
                ProcessDate = r.process_date ?? DateTime.MinValue,
                ProcessedById = r.process_by_id ?? 0,
                RequestedById = r.requested_by_id,
                RequestedDate = r.request_date,
                RequestedStatus = (RequestStatus)r.request_status,
                RequestItemPrimaryType = (int)r.request_item_primary_type,
                RequestSecondaryItemType = (int)r.request_item_secondary_type,
                RequestType = (RequestType)r.request_type,
                NeededDate = r.need_date ?? DateTime.MinValue,
                Subtype = r.subtype,
                Remarks = r.remarks,
                UserId = r.user_id,
                AdminRemarks = r.admin_remarks
            };

            return result;
        }
       
        public bool UpdateRequest(RequestViewModel req)
        {
            var oldRequest = InventoryDatabase.Requests.FirstOrDefault(x => x.id == req.Id);
            if (oldRequest != null)
            {
                oldRequest.process_by_id = req.ProcessedById;
                oldRequest.process_date = req.ProcessDate;
                oldRequest.request_status = (int)req.RequestedStatus;
                oldRequest.admin_remarks = req.AdminRemarks;
                InventoryDatabase.SaveChanges();

                return true;
            }
            return false;

        }

        public bool UpdateRequestStatus(int id, string remark, int user, DateTime need_date, RequestStatus status)
        {
            
            var oldRequest = InventoryDatabase.Requests.FirstOrDefault(x => x.id == id);
            if (oldRequest != null)
            {
                oldRequest.request_status = (int)status;
                oldRequest.process_date = DateTime.Now;
                oldRequest.process_by_id = user;
                oldRequest.requested_by_id = oldRequest.user_id;
                oldRequest.admin_remarks = remark;

                //DateTime need = Convert.ToDateTime(need_date);
                DateTime expected_return = need_date.AddDays(2);

                oldRequest.expected_return_date = expected_return;

                InventoryDatabase.SaveChanges();

                return true;
            }
            return false;

        }

        public List<RequestViewModel> GetApprovedRequests(RequestStatus status)
        {
            var result = new List<RequestViewModel>();
            var reqs = InventoryDatabase.Requests.Where(x => x.request_status == (int)status);
            foreach (Request r in reqs)
            {
                result.Add(new RequestViewModel
                {
                    Id = r.id,
                    ProcessDate = r.process_date ?? DateTime.MinValue,
                    ProcessedById = r.process_by_id ?? 0,
                    RequestedById = r.requested_by_id,
                    RequestedDate = r.request_date,
                    RequestedStatus = (RequestStatus)r.request_status,
                    RequestItemPrimaryType = (int)r.request_item_primary_type,
                    RequestSecondaryItemType = (int)r.request_item_secondary_type,
                    Subtype = r.subtype,
                    RequestType = (RequestType)r.request_type,
                    Remarks = r.remarks,
                    UserId = r.user_id,
                    AdminRemarks = r.admin_remarks,
                    ExpectedReturnDate = r.expected_return_date ?? DateTime.MinValue,
                    NeededDate = r.need_date?? DateTime.MinValue,

                });
            }
            return result;
        }

        public List<RequestViewModel> GetListRequests()
        {
            var result = new List<RequestViewModel>();
            var reqs = InventoryDatabase.Requests;
            foreach (Request r in reqs)
            {
                result.Add(new RequestViewModel
                {
                    Id = r.id,
                    ProcessDate = r.process_date ?? DateTime.MinValue,
                    ProcessedById = r.process_by_id ?? 0,
                    RequestedById = r.requested_by_id,
                    RequestedDate = r.request_date,
                    RequestedStatus = (RequestStatus)r.request_status,
                    RequestItemPrimaryType = (int)r.request_item_primary_type,
                    RequestSecondaryItemType = (int)r.request_item_secondary_type,
                    Subtype = r.subtype,
                    RequestType = (RequestType)r.request_type,
                    Remarks = r.remarks,
                    UserId = r.user_id,
                    AdminRemarks = r.admin_remarks,
                    ExpectedReturnDate = r.expected_return_date ?? DateTime.MinValue,
                    NeededDate = r.need_date ?? DateTime.MinValue,
                });


            }
            return result;
        }

        public List<RequestViewModel> GetExpectedReturnDate()
        {
            //SEND EMAIL NOTIFICATION TO USER - richmond.mendoza@jakagroup.com
            //AND ADMIN - mis@jakagroup.com

            var result = new List<RequestViewModel>();
            var reqs = InventoryDatabase.Requests;
            foreach (Request r in reqs)
            {
                result.Add(new RequestViewModel
                {
                    ExpectedReturnDate = r.expected_return_date ?? DateTime.MinValue,
                });

                var expectedreturn = r.expected_return_date;

                DateTime retdate = Convert.ToDateTime(expectedreturn).Date;

                if (retdate == DateTime.Today)
                {

                    var query = (from u in InventoryDatabase.Requests
                                 where u.expected_return_date == expectedreturn
                                 select u.user_id).FirstOrDefault();

                    
                    EmailSender.SendMail(query);

                }
            }
            return result;
        }







    }
}

