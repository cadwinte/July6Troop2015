using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    
    public class Calculator
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime Day { get; set; }

        public decimal TaxCalculator(decimal price, decimal tax)
        {
            if (tax < 0.00m)
            {throw new ArgumentOutOfRangeException("Tax Rate cannot be less than zero");}

            if (Day == new DateTime(2015, 07, 16))
            {
                tax += tax;
            }

            if (FirstName.StartsWith("J", StringComparison.InvariantCultureIgnoreCase))
            {
                tax += tax;
            }

            if (LastName.ToLower().StartsWith("w"))
            {
                price = price - 1;
            }

            if (Age < 5)
            {
                tax = tax * 0;
            }

            return price + price * tax;
        }
    }
}
