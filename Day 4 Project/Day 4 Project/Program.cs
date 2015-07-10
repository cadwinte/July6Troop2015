using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[] {
                new Employee { FirstName = "Peter", LastName = "Smith"},
                new Employee { FirstName = "Andy", LastName = "Smith"},
                new Employee { FirstName = "Bill", LastName = "Gates"}
            };

            Array.Sort(employees, new LastFirstComparer());

            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.LastName + ", " + emp.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Car : Day_4_Project.ICar
    {
        public string VIN { get; set; }
        public int Miles { get; set; }
    }

    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class LastFirstComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Employee emp1 = x as Employee;
            Employee emp2 = (Employee)y;

            return emp1.LastName.CompareTo(emp2.LastName) == 0 ? 0 : emp1.FirstName.CompareTo(emp2.FirstName);
        }
    }
}
