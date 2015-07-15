using ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingList.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer { FirstName = "Jane", LastName = "Doe", Items = "Apples", Price = -1.99m, },
                new Customer { FirstName = "John", LastName = "Done", Items = "Oranges", Price = -2.75m }
            };

            IndexViewModel vm = new IndexViewModel
            {
                Customers = customers
            };


            return View(vm);
        }

        //public ActionResult Create()
        //{
        //    Product product = new Product();
        //    return View(product);
        //}

        //[HttpPost]
        //public ActionResult Create(Product product)
        //{
        //    return View();
        //}
    }
}