using InventoryManagement.Repository;
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

        public int InsertNewRequest(RequestViewModel newRequest)
        {
            return repo.InsertNewRequest(newRequest);
        }
        public List<RequestViewModel> GetRequestByUserId(int userId)
        {
            return repo.GetRequestByUserId(userId);
        }

        public bool UpdateRequest(RequestViewModel req)
        {
            return repo.UpdateRequest(req);
        }
    }
}
