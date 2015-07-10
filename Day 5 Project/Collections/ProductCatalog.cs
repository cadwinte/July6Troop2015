using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class ProductCatalog
    {
        List<Product> _products = new List<Product>();

        public ProductCatalog()
        {
            _products.Add(new Product { Id = "ID1", Name = "tacos", Price = 3.50m });
            _products.Add(new Product { Id = "ID2", Name = "jelly", Price = 2.00m });
            _products.Add(new Product { Id = "ID3", Name = "bread", Price = 1.75m });
        }

        public Product Lookup(string id)
        {
            return _products.Find(p => p.Id == id); //Find(p => p.Id == id <-- this is a lambda 
        }
    }
}
