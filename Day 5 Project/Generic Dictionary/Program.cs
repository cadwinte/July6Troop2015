using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductCatalog catalog = new ProductCatalog();
            Product product = catalog.Lookup("P2");
            Debug.Assert(product != null, "Product with Id P2 not found");

            Dictionary<string, string> states = new Dictionary<string, string>();
            states.Add("ca", "California");
            states.Add("tx", "Texas");
            states.Add("wa", "Washington");

            string texas = states["tx"];

           if (states.ContainsKey("tx"))
           {
               Console.WriteLine("We have Texas in a collection");
           }

           if (states.ContainsValue("Texas"))
           {
               Console.WriteLine("We have Texas in a collection");
           }
             
            string value = null;
            if (states.TryGetValue("tx", out value))
            {

            }
        }
    }
}
