using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        public static decimal CalculateTotalPrice(decimal price, decimal taxRate)
        {
            if (price < 0)
            {
                throw new ArgumentOutOfRangeException("Price cannot be less than zero");
            }

            if (taxRate > 0.1m || taxRate < 0.00m)
            {
                throw new ArgumentOutOfRangeException("Tax Rate cannot be higher than 10% or less than zero");
            }

            return price + price * taxRate;
        }

        static void Main(string[] args)
        {
            decimal tacos = CalculateTotalPrice(100m, 0.08m);
            Console.WriteLine("Your total comes out to " + tacos.ToString("c"));

            Console.ReadLine();
        }

    }
}
