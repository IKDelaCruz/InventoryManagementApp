using InventoryManagement.Repository;
using InventoryManagement.Utils;
using InventoryManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Model
{
    public class RequestModel : BaseModel
    {
        RequestRepository repo;
        public RequestModel()
        {
            repo = new RequestRepository();
        }

        public int CreateNewRequest(RequestViewModel newRequest)
        {
            var result = repo.InsertNewRequest(newRequest);
            
            //SEND EMAIL NOTIFICATION TO USER - richmond.mendoza@jakagroup.com
            //AND ADMIN - mis@jakagroup.com

            //EmailSender.SendMail();

            return result;

        }


        public List<RequestViewModel> GetRequestByUserId(int userId)
        {
            return repo.GetRequestByUserId(userId);
        }

        public bool UpdateRequest(RequestViewModel req)
        {
            return repo.UpdateRequest(req);
        }
        public bool ApproveRequest(int id, string remark, int user, int itemId = 0)
        {
            return repo.UpdateRequestStatus(id, remark, user, RequestStatus.Approved, itemId);
        }
        public bool DeliverRequest(int id, string remark, int user)
        {
            return repo.UpdateRequestStatus(id, remark, user, RequestStatus.Delivered);
        }
        public bool DeclineRequest(int id, string remark, int user)
        {
            return repo.UpdateRequestStatus(id, remark, user,  RequestStatus.Declined);
        }
        public RequestViewModel GetRequestById(int requestId)
        {
            return repo.GetRequestById(requestId);
        }

        public List<RequestViewModel> GetRequestByStatus(RequestStatus status, DateTime from, DateTime to)
        {
            var result = repo.GetRequestByStatus(status, from, to);


            //foreach (RequestViewModel r in result)
            //{
            //    r.UserFullnameEmail = Singleton.Instance.UserModel.GetUsersById(r.UserId).LastnameFirstNameUsername;

            //}

            return result;
        }

        public List<RequestViewModel> GetApprovedReqs(RequestStatus status)
        {
            var result = repo.GetApprovedRequests(status);


            foreach (RequestViewModel r in result)
            {
                r.UserFullnameEmail = Singleton.Instance.UserModel.GetUsersById(r.UserId).LastnameFirstNameUsername;

            }

            return result;
        }
        public List<RequestViewModel> GetDeclinedReqs(RequestStatus status)
        {
            var result = repo.GetDeclinedRequests(status);


            foreach (RequestViewModel r in result)
            {
                r.UserFullnameEmail = Singleton.Instance.UserModel.GetUsersById(r.UserId).LastnameFirstNameUsername;

            }

            return result;
        }

        public List<RequestViewModel> SendEmail()
        {
            return repo.GetExpectedReturnDate();
        }

    }
}
