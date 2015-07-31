using JavaScriptDay18MVC.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Mvc;

namespace JavaScriptDay18MVC.Controllers.API
{
    public class ProductsController : ApiController
    {
        private static ConcurrentStack<Product> _products; //Workaround for not having a Database 

        static ProductsController()
        {
            _products = new ConcurrentStack<Product>(new List<Product>
            {
                new Product { Name = "Milk", Price = 2.33m },
                new Product { Name = "Cheese", Price = 55.33m },
                new Product { Name = "Tesla", Price = 8989.33m }
            });

        }

        public IHttpActionResult Get()
        {
            var products = _products;

            return Ok(products);
        }

        public IHttpActionResult Post(Product product)
        {
            if (ModelState.IsValid)
            {
                _products.Push(product);
                return Created("/api/products/", product);
            }

            return BadRequest(ModelState);
        }
    }
}