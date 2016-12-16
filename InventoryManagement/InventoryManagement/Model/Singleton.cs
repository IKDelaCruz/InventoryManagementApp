using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Model
{
    public class Singleton
    {
        private static Singleton instance;

        public UserModel UserModel { get; set; }
        public ItemModel ItemModel { get; set; }

        public CompanyDepartmentModel CompanyDepartmentModel { get; set; }

        public Singleton()
        {
            UserModel = new UserModel();
            ItemModel = new ItemModel();
            CompanyDepartmentModel = new CompanyDepartmentModel();
        }
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
