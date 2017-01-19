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

            var user = InventoryDatabase.Users.FirstOrDefault(x => x.username == username && x.password == password);
            if (user != null)
            {
                return new UserViewModel
                {
                    Id = user.id,
                    Password = user.password,
                    Username = user.username,
                    UserType = user.type,
                    Firstname = user.first_name,
                    Lastname = user.last_name
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
            InventoryDatabase.Users.Add(newUser);
            InventoryDatabase.SaveChanges();

            return newUser.id;
        }

        public bool UpdateUser(int userId, string firstName, string lastName, int companyId, int departmentId)
        {
            var user = InventoryDatabase.Users.FirstOrDefault(h => h.id == userId);
            if (user != null)
            {
                user.first_name = firstName;
                user.last_name = lastName;
                user.company = companyId;
                user.department = departmentId;

                InventoryDatabase.SaveChanges();

                return true;
            }

            return false;
        }
        public UserViewModel GetUser(string username)
        {
            var user = InventoryDatabase.Users.FirstOrDefault(h => h.username == username);
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
            var user = InventoryDatabase.Users.ToList();
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
            var user = InventoryDatabase.Users.Where(h => h.department == departmentId).ToList();
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
