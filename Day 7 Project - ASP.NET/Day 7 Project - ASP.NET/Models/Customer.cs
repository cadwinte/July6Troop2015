using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day_7_Project___ASP.NET.Models
{
    public class Customer
    {
        public Customer()
        {
            this.ShippingAddress = new Address();
            this.MailingAddress = new Address();
        }

        public Address ShippingAddress { get; set; }
        public Address MailingAddress { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}