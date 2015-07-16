﻿using PassingData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassingData.Controllers
{
    public class ProductsController : Controller
    {

        public ActionResult Index()
        {

        List<Product> products = new List<Product>
        {
            new Product { Name = "Milk", Price = 2.33m},
            new Product { Name = "Eggs", Price = 1.09m},
            new Product { Name = "Cheese", Price = 12.00m}
        };

        IndexViewModel vm = new IndexViewModel
        {
            Products = products
        };

            return View(vm);
        }
    }
}