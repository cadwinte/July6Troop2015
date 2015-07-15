using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingList.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Items { get; set; }
        public decimal Price { get; set; }

        public decimal GetItems()
        {
            return this.Price += Price;
        }
    }
}