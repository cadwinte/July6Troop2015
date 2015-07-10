using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            ProductCatalog catalog = new ProductCatalog();
            Product product1 = catalog.Lookup("ID1");

            //ArrayList
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Name = "Bill Gates" });
            customers.Add(new Customer { Name = "Steve Jobs" });

            List<int> numbers = new List<int>();
            {
                numbers.Add(32);
                numbers.Add(94);
            }

            Customer customer1 = customers[0]; 
            Console.WriteLine(customer1.Name);

            foreach (Customer item in customers) //Calling all the items in the list
            {
                if (item is Customer)
                {
                    Console.WriteLine(item.Name);
                }
            }

            Console.ReadLine();
        }
    }
}
