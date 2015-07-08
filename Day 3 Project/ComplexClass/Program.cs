using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust1 = new Customer
            {
                BillingAddress =
                {
                    City = "Houston",
                    Street = "3232 Detering",
                    ZIP = "77007"
                },
                ShippingAddress =
                {
                    City = "Denver",
                    Street = "1584 Elway",
                    ZIP = "88550"
                },
                FirstName = "Cade",
                LastName = "Winter"
            };
        }
    }

    class Customer
    {
        public Customer()
        {
            BillingAddress = new Address();
            ShippingAddress = new Address();
            DateCreated = DateTime.Now;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }

        public DateTime DateCreated { get; set; }
    }

    class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string ZIP { get; set; }
    }
}
