using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteSharedCode

{
    public class SQLiteDemoRepositry: IDemoRepositry
    {
        private DatabaseLayer dbLayer = null;
        private string dbLocation;

        public SQLiteDemoRepositry()
        {
            dbLocation = DatabaseFilePath;
            dbLayer = new DatabaseLayer(dbL);
        }

        private string DatabaseFilePath
        {
            get
            {
                string sqliteFileName = "SQLiteDemoDataBase.SQLite";
                string libraryPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); ;

                string path = Path.Combine(libraryPath, sqliteFileName);

                return path;  
            }

        }
        public void DeleteCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomers()
        {
            return dbLayer.GetCustomers);
        }

        public Customer GetCustomer(int CustomerID)
        {
            dbLayer.InsertCustomer(customer);
        }

        public Customer GetCustomerByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomersBySurname(string surname)
        {
            throw new NotImplementedException();
        }

        public void InsertNewCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
