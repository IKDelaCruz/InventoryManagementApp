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


            var newReq = new request
            {
                request_date = req.RequestedDate,
                request_requested_by_id = req.RequestedById,
                request_item_primary_type = (int)req.RequestItemPrimaryType,
                request_item_secondary_type = (int)req.RequestSecondaryItemType,
                request_subtype = req.Subtype,
                request_status = (int)req.RequestedStatus,
                request_user_id = req.UserId,
                request_type = (int)req.RequestType,
                request_need_date = req.NeededDate,
                request_remarks = req.Remarks,
                request_admin_remarks = req.AdminRemarks
            };
            InventoryDatabase.requests.Add(newReq);
            if (InventoryDatabase.SaveChanges() > 0)
                return newReq.request_id;
            else
                return 0;
        }
        public List<RequestViewModel> GetRequestByUserId(int userId)
        {
            var result = new List<RequestViewModel>();
            var reqs = InventoryDatabase.requests.Where(x => x.request_user_id == userId);
            foreach (request r in reqs)
            {
                result.Add(new RequestViewModel
                {
                    Id = r.request_id,
                    ProcessDate = r.request_process_date ?? DateTime.MinValue,
                    ProcessedById = r.request_process_by_id ?? 0,
                    RequestedById = r.request_requested_by_id,
                    RequestedDate = r.request_date,
                    RequestedStatus = (RequestStatus)r.request_status,
                    RequestItemPrimaryType = (int)r.request_item_primary_type,
                    RequestSecondaryItemType = (int)r.request_item_secondary_type,
                    RequestType = (RequestType)r.request_type,
                    Remarks = r.request_remarks,
                    UserId = r.request_id,
                    AdminRemarks = r.request_admin_remarks
                });
            }
            return result;
        }
        public List<RequestViewModel> GetRequestByStatus(RequestStatus status, DateTime from, DateTime to)
        {
            var result = new List<RequestViewModel>();
            var reqs = InventoryDatabase.vw_request_details.Where(x => x.request_date > from && x.request_date < to && x.request_status == (int)status);


            foreach (vw_request_details r in reqs)
            {
                result.Add(new RequestViewModel
                {
                    Id = r.request_id,
                    ProcessDate = r.request_process_date ?? DateTime.MinValue,
                    ProcessedById = r.request_process_by_id ?? 0,
                    RequestedById = r.request_requested_by_id,
                    RequestedDate = r.request_date,
                    RequestedStatus = (RequestStatus)r.request_status,
                    RequestItemPrimaryType = (int)r.request_item_primary_type,
                    RequestSecondaryItemType = (int)r.request_item_secondary_type,
                    Subtype = r.request_subtype,
                    
                    RequestType = (RequestType)r.request_type,
                    RequestTypeInt = r.request_type,
                    Remarks = r.request_remarks,
                    UserId = r.request_user_id,
                    AdminRemarks = r.request_admin_remarks,
                    ExpectedReturnDate = r.request_expected_return_date ?? DateTime.MinValue,
                    NeededDate = r.request_need_date ?? DateTime.MinValue,
                    UserFullnameEmail = r.user_last_name + ", " + r.user_first_name
                });
            }
            return result;
        }
        public RequestViewModel GetRequestById(int requestId)
        {
            var r = InventoryDatabase.requests.FirstOrDefault(x => x.request_id == requestId);
            var result = new RequestViewModel
            {
                Id = r.request_id,
                ProcessDate = r.request_process_date ?? DateTime.MinValue,
                ProcessedById = r.request_process_by_id ?? 0,
                RequestedById = r.request_requested_by_id,
                RequestedDate = r.request_date,
                RequestedStatus = (RequestStatus)r.request_status,
                RequestItemPrimaryType = (int)r.request_item_primary_type,
                RequestSecondaryItemType = (int)r.request_item_secondary_type,
                RequestType = (RequestType)r.request_type,
                NeededDate = r.request_need_date ?? DateTime.MinValue,
                Subtype = r.request_subtype,
                Remarks = r.request_remarks,
                UserId = r.request_user_id,
                AdminRemarks = r.request_admin_remarks
            };

            return result;
        }

        public bool UpdateRequest(RequestViewModel req)
        {
            var oldRequest = InventoryDatabase.requests.FirstOrDefault(x => x.request_id == req.Id);
            if (oldRequest != null)
            {
                oldRequest.request_process_by_id = req.ProcessedById;
                oldRequest.request_process_date = req.ProcessDate;
                oldRequest.request_status = (int)req.RequestedStatus;
                oldRequest.request_remarks = req.AdminRemarks;
                InventoryDatabase.SaveChanges();

                return true;
            }
            return false;

        }

        public bool UpdateRequestStatus(int id, string remark, int user, RequestStatus status)
        {

            var oldRequest = InventoryDatabase.requests.FirstOrDefault(x => x.request_id == id);
            if (oldRequest != null)
            {
                oldRequest.request_status = (int)status;
                oldRequest.request_process_date = DateTime.Now;
                oldRequest.request_process_by_id = user;
                oldRequest.request_admin_remarks = remark;


                InventoryDatabase.SaveChanges();

                return true;
            }
            return false;

        }

        public List<RequestViewModel> GetApprovedRequests(RequestStatus status)
        {
            var result = new List<RequestViewModel>();
            var reqs = InventoryDatabase.requests.Where(x => x.request_status == (int)status);
            foreach (request r in reqs)
            {
                result.Add(new RequestViewModel
                {
                    Id = r.request_id,
                    ProcessDate = r.request_process_date ?? DateTime.MinValue,
                    ProcessedById = r.request_process_by_id ?? 0,
                    RequestedById = r.request_requested_by_id,
                    RequestedDate = r.request_date,
                    RequestedStatus = (RequestStatus)r.request_status,
                    RequestItemPrimaryType = (int)r.request_item_primary_type,
                    RequestSecondaryItemType = (int)r.request_item_secondary_type,
                    Subtype = r.request_subtype,
                    RequestType = (RequestType)r.request_type,
                    RequestTypeInt = r.request_type,
                    Remarks = r.request_remarks,
                    UserId = r.request_user_id,
                    AdminRemarks = r.request_admin_remarks,
                    ExpectedReturnDate = r.request_expected_return_date ?? DateTime.MinValue,
                    NeededDate = r.request_need_date ?? DateTime.MinValue,

                });
            }
            return result;
        }

        public List<RequestViewModel> GetDeclinedRequests(RequestStatus status)
        {
            var result = new List<RequestViewModel>();
            var reqs = InventoryDatabase.requests.Where(x => x.request_status == (int)status);
            foreach (request r in reqs)
            {
                result.Add(new RequestViewModel
                {
                    Id = r.request_id,
                    ProcessDate = r.request_process_date ?? DateTime.MinValue,
                    ProcessedById = r.request_process_by_id ?? 0,
                    RequestedById = r.request_requested_by_id,
                    RequestedDate = r.request_date,
                    RequestedStatus = (RequestStatus)r.request_status,
                    RequestItemPrimaryType = (int)r.request_item_primary_type,
                    RequestSecondaryItemType = (int)r.request_item_secondary_type,
                    Subtype = r.request_subtype,
                    RequestType = (RequestType)r.request_type,
                    RequestTypeInt = r.request_type,
                    Remarks = r.request_remarks,
                    UserId = r.request_user_id,
                    AdminRemarks = r.request_admin_remarks,
                    ExpectedReturnDate = r.request_expected_return_date ?? DateTime.MinValue,
                    NeededDate = r.request_need_date ?? DateTime.MinValue,

                });
            }
            return result;
        }

        public List<RequestViewModel> GetListRequests()
        {
            var result = new List<RequestViewModel>();
            var reqs = InventoryDatabase.requests;
            foreach (request r in reqs)
            {
                result.Add(new RequestViewModel
                {
                    Id = r.request_id,
                    ProcessDate = r.request_process_date ?? DateTime.MinValue,
                    ProcessedById = r.request_process_by_id ?? 0,
                    RequestedById = r.request_requested_by_id,
                    RequestedDate = r.request_date,
                    RequestedStatus = (RequestStatus)r.request_status,
                    RequestItemPrimaryType = (int)r.request_item_primary_type,
                    RequestSecondaryItemType = (int)r.request_item_secondary_type,
                    Subtype = r.request_subtype,
                    RequestType = (RequestType)r.request_type,
                    Remarks = r.request_remarks,
                    UserId = r.request_user_id,
                    AdminRemarks = r.request_admin_remarks,
                    ExpectedReturnDate = r.request_expected_return_date ?? DateTime.MinValue,
                    NeededDate = r.request_need_date ?? DateTime.MinValue,
                });


            }
            return result;
        }

        public List<RequestViewModel> GetExpectedReturnDate()
        {
            //SEND EMAIL NOTIFICATION TO USER - richmond.mendoza@jakagroup.com
            //AND ADMIN - mis@jakagroup.com

            var result = new List<RequestViewModel>();
            var reqs = InventoryDatabase.requests;
            foreach (request r in reqs)
            {
                result.Add(new RequestViewModel
                {
                    ExpectedReturnDate = r.request_expected_return_date ?? DateTime.MinValue,
                });

                var expectedreturn = r.request_expected_return_date;

                DateTime retdate = Convert.ToDateTime(expectedreturn).Date;

                if (retdate == DateTime.Today)
                {

                    var query = (from u in InventoryDatabase.requests
                                 where u.request_expected_return_date == expectedreturn
                                 select u.request_user_id).FirstOrDefault();


                    EmailSender.SendMail(query);

                }
            }
            return result;
        }







    }
}

