using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Dictionary
{
    class ProductCatalog
    {
        public ProductCatalog()
        {
            Dictionary<string, string> products = new Dictionary<string, string>();
            products.Add("ID1", "Cellphone");
            products.Add("ID2", "Macbook");
            products.Add("ID3", "911 Turbo S");
        }
    }
}
