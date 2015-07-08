using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("iPhone", 199.99m, 32);
            Console.WriteLine(product1.ProductName);
            Console.WriteLine(product1.ProductPrice);
            Console.WriteLine(product1.UnitsInStock);
            Console.WriteLine(product1.ProductDescription);

            Product product2 = new Product("MacBook Pro", 1499.99m, 5, "Laptop");
            Console.WriteLine("Name: {0}, Price: {1:C}, Units In Stock: {2}, Description: {3}", product2.ProductName, product2.ProductPrice, product2.UnitsInStock, product2.ProductDescription);

            Console.ReadLine();
        }
        class Product
        {
            public string ProductName { get; set; }
            public decimal ProductPrice { get; set; }
            public int UnitsInStock { get; set; }
            public string ProductDescription { get; private set; }

            public Product(string productName, decimal productPrice, int unitsInStock) : this(productName, productPrice, unitsInStock, null)
            {

            }

            public Product(string productName, decimal productPrice, int unitsInStock, string productDescription)
            {
                ProductName = productName;
                ProductPrice = productPrice;
                UnitsInStock = unitsInStock;
                ProductDescription = productDescription;
            }
        }
    }
}
