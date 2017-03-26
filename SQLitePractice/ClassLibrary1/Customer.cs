using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite.Net.Attributes;

namespace SQLiteSharedCode
{ 

    [Table("Customers")]
    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int customerID, string firstName, string surname, string email)
        {
            CustomerID = customerID;
            FirstName = firstName;
            Surname = surname;
            Email = email;
        }
        [PrimaryKey, AutoIncrement]
        public int CustomerID {
            get;
            set;
        }
        public string FirstName {
            get;
            set;
        }
        public string Surname {
            get;
            set;
        }
        public string Email {
            get;
            set;
        }

    }
}
