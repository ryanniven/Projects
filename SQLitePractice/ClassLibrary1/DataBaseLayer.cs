using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteSharedCode
{
    public class DatabaseLayer
    {
        private SQLiteConnection connection;
        public DatabaseLayer(string dbLocation)
        {
            connection = new SQLiteConnection(new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid(), dbLocation);
            connection.CreateTable<Customer>();
        }

        public List<Customer> GetCustomers()
        {
            return new list<Customer>(connection.Table<Customer>());
        }

        public void InsertCustomer(Customer customer)
        {
            connection.Insert(Customer);

        }
    }
}
