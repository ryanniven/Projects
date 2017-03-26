using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteSharedCode
{
    public interface IDemoRepositry
    {
        Customer GetCustomer(int CustomerID);
        Customer GetCustomerByEmail(string email);
        List<Customer> GetCustomersBySurname(string surname);
        List<Customer> GetAllCustomers();

        void InsertNewCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);

    }
}
