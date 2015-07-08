using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee bill = new FullTimeEmployee();
                bill.FirstName = "Bill";
                bill.LastName = "Gates";
                bill.YearsEmployed = 5;

            ContractEmployee steve = new ContractEmployee();
                steve.FirstName = "Steve";
                steve.LastName = "Jobs";
                steve.MonthsEmployed = 2;

                Console.WriteLine(steve.ShowFullName());
                Console.WriteLine(steve.MonthsEmployed);
                Console.WriteLine(bill.ShowFullName());
                Console.WriteLine(bill.YearsEmployed);
                Console.ReadLine();
        }
    }

    abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ShowFullName()
        {
            return this.FirstName + " " + this.LastName;
        }
    }

    class FullTimeEmployee : Employee
    {
        public int YearsEmployed { get; set; }
    }

    class ContractEmployee : Employee
    {
        public int MonthsEmployed { get; set; }
    }
}
