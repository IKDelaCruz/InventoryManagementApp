using InventoryManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Repository
{
    public class UserRepository : BaseRepository
    {
        public UserViewModel ValidateUsernameAndPassword(string username, string password)
        {

            var user = Database.Users.FirstOrDefault(h => h.username == username && h.password == password);
            if (user != null)
            {
                return new UserViewModel
                {
                    Id = user.id,
                    Password = user.password,
                    Username = user.username,
                    UserType = user.type
                };
            }
            return null;
        }

        public int CreateNewUser(string username, string password, int type)
        {

            var newUser = new User
            {
                username = username,
                password = password,
                type = type
            };
            Database.Users.Add(newUser);
            Database.SaveChanges();

            return newUser.id;
        }

        public bool UpdateUser(int userId, string firstName, string lastName, int companyId, int departmentId)
        {
            var user = Database.Users.FirstOrDefault(h => h.id == userId);
            if (user != null)
            {
                user.first_name = firstName;
                user.last_name = lastName;
                user.company = companyId;
                user.department = departmentId;

                Database.SaveChanges();

                return true;
            }

            return false;
        }
        public UserViewModel GetUser(string username)
        {
            var user = Database.Users.FirstOrDefault(h => h.username == username);
            if (user != null)
            {
                return new UserViewModel
                {
                    Id = user.id,
                    Password = user.password,
                    Username = user.username,
                    UserType = user.type
                };
            }

            return null;
        }
        public List<UserViewModel> GetUsers()
        {
            var list = new List<UserViewModel>();
            var user = Database.Users.ToList();
            foreach (User u in user)
            {
                list.Add(new UserViewModel
                {
                    Id = u.id,
                    Password = u.password,
                    Username = u.username,
                    UserType = u.type,
                    Firstname = u.first_name,
                    Lastname = u.last_name,
                    LastnameFirstName = u.last_name + ", " + u.first_name
                });
            }

            return list;
        }
        public List<UserViewModel> GetUsersByDepartmentId(int departmentId)
        {
            var list = new List<UserViewModel>();
            var user = Database.Users.Where(h => h.department == departmentId).ToList();
            foreach (User u in user)
            {
                list.Add(new UserViewModel
                {
                    Id = u.id,
                    Password = u.password,
                    Username = u.username,
                    UserType = u.type,
                    Firstname = u.first_name,
                    Lastname = u.last_name,
                    LastnameFirstName = u.last_name + ", " + u.first_name
                });
            }

            return list;
        }
    }
}
