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
        public RequestModel RequestModel { get; set; }
        public TransactionModel TransactionModel { get; set; }
        public CompanyDepartmentModel CompanyDepartmentModel { get; set; }
        public ItemSubTypeModel ItemSubTypeModel { get; set; }

        public ItemTypeModel ItemTypeModel { get; set; }

        public BrandModel BrandModel { get; set; }

        public Singleton()
        {
            ItemTypeModel = new ItemTypeModel();
            UserModel = new UserModel();
            ItemModel = new ItemModel();
            TransactionModel = new TransactionModel();
            CompanyDepartmentModel = new CompanyDepartmentModel();
            ItemSubTypeModel = new ItemSubTypeModel();
            RequestModel = new RequestModel();
            BrandModel = new BrandModel();
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
