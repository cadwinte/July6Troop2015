using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Dictionary
{
    class ProductCatalog
    {
        private Dictionary<string, Product> _products;

        public ProductCatalog()
        {
            _products = new Dictionary<string, Product>();

            _products.Add("P1", new Product { Id = "P1", Name = "Peanut Butter", Price = 3.00m });
            _products.Add("P2", new Product { Id = "P2", Name = "Jelly", Price = 2.99m });
            _products.Add("P3", new Product { Id = "P3", Name = "Cookie", Price = 1.50m });
        }

        public Product Lookup(string id)
        {
            return _products[id];
        }
    }
}
