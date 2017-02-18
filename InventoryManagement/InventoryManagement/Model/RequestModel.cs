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
        public bool ApproveRequest(int id, string remark, int user, DateTime need_date)
        {
            return repo.UpdateRequestStatus(id, remark, user, need_date, RequestStatus.Approved);
        }
        public bool DeclineRequest(int id, string remark, int user, DateTime need_date)
        {
            return repo.UpdateRequestStatus(id, remark, user, need_date, RequestStatus.Declined);
        }
        public RequestViewModel GetRequestById(int requestId)
        {
            return repo.GetRequestById(requestId);
        }

        public List<RequestViewModel> GetRequestByStatus(RequestStatus status)
        {
            var result = repo.GetRequestByStatus(status);


            foreach (RequestViewModel r in result)
            {
                r.UserFullnameEmail = Singleton.Instance.UserModel.GetUsersById(r.UserId).LastnameFirstNameUsername;

            }

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
