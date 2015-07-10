using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee
            {
                Name = "Bill Gates",
                StartDate = DateTime.Parse("April 4, 1975")
            };

            DateTime endDate = employee1.EndDate.GetValueOrDefault(DateTime.Now);

            if (employee1.EndDate != null)
            {
                Console.WriteLine("End date was " + employee1.EndDate);
            }

            if (employee1.EndDate.HasValue)
            {
                Console.WriteLine("End date was " + employee1.EndDate);
            }

            int result = 0;

            if (int.TryParse("45", out result))
            {
                Console.WriteLine("Parse your value successfully");
            }
            else
            {
                Console.WriteLine("Sorry, I was not able to parse your value into an int");
            }

            Console.ReadLine();
        }
    }
}
