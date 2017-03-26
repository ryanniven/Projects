using System;

namespace DBPractice
{
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

        public int CustomerID
        {
            get;
            set;
        }
        public int FirstName
        {
            get;
            set;
        }
        public int Surname
        {
            get;
            set;
        }
        public int Email
        {
            get;
            set;
        }
    }
}
