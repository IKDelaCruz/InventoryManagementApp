
using InventoryManagement.Repository;
using InventoryManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Model
{
    public class UserModel : BaseModel
    {
        UserRepository userRepository;
        public UserModel()
        {
            userRepository = new UserRepository();
        }
        public enum UserType
        {
            Admin = 1,
            Custodian,
            User
        }
        public UserViewModel CurrentUser { get;private set; }

        public UserViewModel AuthenticateUser(string username, string password)
        {
            
            CurrentUser = userRepository.ValidateUsernameAndPassword(username, password);
            return CurrentUser;
        }
        public bool LogoutUser()
        {
            CurrentUser = null;
            return true;
        }
        public int CreateNewUser(string username, string password, UserType userType)
        {
            return userRepository.CreateNewUser(username, password, (int)userType);
        }
        public bool UpdateUser(int userId, string firstName, string lastName, int companyId, int departmentId)
        {
            return userRepository.UpdateUser(userId, firstName, lastName, companyId, departmentId);
        }
        public void CheckDefaultUser()
        {
            var adminUser = userRepository.GetUser("admin");
            if(adminUser == null)
            {
                userRepository.CreateNewUser("admin", "admin", 1);
            }
        }
        public List<UserViewModel> GetUsers()
        {
            return userRepository.GetUsers();
        }
        public List<UserViewModel> GetUsersByDepartmentId(int departmentId)
        {
            return userRepository.GetUsersByDepartmentId(departmentId);
        }
    }
}
