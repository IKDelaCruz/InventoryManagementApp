using InventoryManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Repository
{
    public class UserRepository : BaseRepository
    {
        public UserViewModel ValidateUsernameAndPassword(string username, string password)
        {

            var user = InventoryDatabase.users.FirstOrDefault(x => x.user_username == username && x.user_password == password);
            if (user != null)
            {
                return new UserViewModel
                {
                    Id = user.user_id,
                    Password = user.user_password,
                    Username = user.user_username,
                    UserType = user.user_type,
                    Firstname = user.user_first_name,
                    Lastname = user.user_last_name
                };
            }
            return null;
        }
        public int CreateNewUser(string username, string password, int type, string firstname, string lastname, int departmentId, bool isMale = true)
        {

            var newUser = new user
            {
                user_username = username,
                user_password = password,
                user_type = type,
                user_first_name = firstname,
                user_last_name = lastname,
                user_department = departmentId,
                is_male = isMale

            };
            InventoryDatabase.users.Add(newUser);
            try
            {
                InventoryDatabase.SaveChanges();
                return newUser.user_id;
            }
            catch
            {
                return 0;
            }

            
        }
        public bool UpdateUser(int userId, string firstName, string lastName, int companyId, int departmentId, int userType = 3, string password = "")
        {
            var user = InventoryDatabase.users.FirstOrDefault(h => h.user_id == userId);
            if (user != null)
            {
                user.user_first_name = firstName;
                user.user_last_name = lastName;
                user.user_company = companyId;
                user.user_department = departmentId;
                user.user_type = userType;
                if(password != "")
                {
                    user.user_password = password;
                }

                InventoryDatabase.SaveChanges();

                return true;
            }

            return false;
        }
        public UserViewModel GetUser(string username)
        {
            var user = InventoryDatabase.users.FirstOrDefault(h => h.user_username == username);
            if (user != null)
            {
                return new UserViewModel
                {
                    Id = user.user_id,
                    Password = user.user_password,
                    Username = user.user_username,
                    UserType = user.user_type
                };
            }

            return null;
        }
        public UserViewModel GetUserById(int id)
        {
            var user = InventoryDatabase.vw_user_membership_detail.FirstOrDefault(h => h.UserId == id);
            if (user != null)
            {
                return new UserViewModel
                {
                    Id = user.UserId,
                    Password = user.UserPassword,
                    Username = user.UserName,
                    UserType = user.UserTyp,
                    Firstname = user.UserFirstName,
                    Lastname = user.UserLastName,
                    LastnameFirstName = user.UserLastName + ", " + user.UserFirstName,
                    LastnameFirstNameUsername = user.UserLastName + ", " + user.UserFirstName + " (" + user.UserName + ")",
                    Department = user.UserDepartment,
                    Company = user.UserCompany,
                    DepartmentId = user.UserDeparmentId ?? 0,
                    CompanyId = user.UserCompanyId ?? 0
                };
            }

            return null;
        }
        public UserViewModel GetUserByUsername(string username)
        {
            var user = InventoryDatabase.users.AsNoTracking().FirstOrDefault(h => h.user_username == username);
            if (user != null)
            {
                return new UserViewModel
                {
                    Id = user.user_id,
                    Password = user.user_password,
                    Username = user.user_username,
                    UserType = user.user_type,
                    Firstname = user.user_first_name,
                    Lastname = user.user_last_name,
                    LastnameFirstName = user.user_last_name + ", " + user.user_first_name,
                    LastnameFirstNameUsername = user.user_last_name + ", " + user.user_first_name + " (" + user.user_username + ")"
                };
            }

            return null;
        }
        public List<UserViewModel> GetUsers()
        {
            var list = new List<UserViewModel>();
            var users = InventoryDatabase.users.ToList();
            foreach (user u in users)
            {
                list.Add(new UserViewModel
                {
                    
                    Id = u.user_id,
                    Password = u.user_password,
                    Username = u.user_username,
                    UserType = u.user_type,
                    Firstname = u.user_first_name,
                    Lastname = u.user_last_name,
                    LastnameFirstName = u.user_last_name + ", " + u.user_first_name,
                    LastnameFirstNameUsername = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(u.user_last_name) + ", " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(u.user_first_name) + " (" + u.user_username + ")"
                    
                });
            }

            return list.OrderBy(x=> x.LastnameFirstNameUsername).ToList();
        }
        public List<UserViewModel> GetUsersByDepartmentId(int departmentId)
        {
            var list = new List<UserViewModel>();
            var users = InventoryDatabase.users.Where(h => h.user_department == departmentId).ToList();
            foreach (user u in users)
            {
                list.Add(new UserViewModel
                {
                    Id = u.user_id,
                    Password = u.user_password,
                    Username = u.user_username,
                    UserType = u.user_type,
                    Firstname = u.user_first_name,
                    Lastname = u.user_last_name,
                    LastnameFirstName = u.user_last_name + ", " + u.user_first_name,
                    LastnameFirstNameUsername = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(u.user_last_name) + ", " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(u.user_first_name) + " (" + u.user_username + ")"
                });
            }

            return list;
        }
    }
}
