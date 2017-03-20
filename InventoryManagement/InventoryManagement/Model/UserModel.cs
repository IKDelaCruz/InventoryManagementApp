
using AuthenticationLibrary;
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
            User,

        }
        public UserViewModel CurrentUser { get; private set; }

        public UserViewModel AuthenticateUser(string username, string password, bool useLDAP)
        {
            if (useLDAP)
            {
                var ldap = new LDAPManager();
                var result = ldap.AuthenticateLDAP(username, password);
                if (result)
                    CurrentUser = userRepository.GetUserByUsername(username);
            }
            else
            {
                CurrentUser = userRepository.ValidateUsernameAndPassword(username, password);
            }


            return CurrentUser;
        }
        public bool LogoutUser()
        {
            CurrentUser = null;
            return true;
        }
        public int CreateNewUser(string username, string password, UserType userType, string firstname, string lastname, int departmentId, bool isMale = true, bool disabled = false)
        {
            return userRepository.CreateNewUser(username, password, (int)userType, firstname, lastname, departmentId, isMale, disabled);
        }
        public bool UpdateUser(int userId, string firstName, string lastName, int departmentId, UserType userType, string password = "", bool disabled = false)
        {
            return userRepository.UpdateUser(userId, firstName, lastName, departmentId, (int)userType, password, disabled);
        }
        //public void CheckDefaultUser()
        //{
        //    var adminUser = userRepository.GetUser("admin");
        //    if(adminUser == null)
        //    {
        //        userRepository.CreateNewUser("admin", "admin", 1, "Admin", "Admin", 0);
        //    }
        //}
        public List<UserViewModel> GetUsers()
        {
            return userRepository.GetUsers(false);
        }
        public UserViewModel GetUsersById(int id)
        {
            return userRepository.GetUserById(id);
        }
        public UserViewModel GetUsersByUsername(string username)
        {
            return userRepository.GetUserByUsername(username);
        }
        public List<UserViewModel> GetUsersByDepartmentId(int departmentId)
        {
            return userRepository.GetUsersByDepartmentId(departmentId).OrderBy(h => h.LastnameFirstName).ToList();
        }
    }
}
