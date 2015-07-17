using PhoneNumberTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhoneNumberTemplate.Controllers
{
    public class PhoneController : Controller
    {
        private IList<Customer> _customers;

        public PhoneController()
        {
            _customers = new List<Customer>
            {
                new Customer { FirstName = "Steve", LastName = "Jobs", Phone = "8066551532" },
                new Customer { FirstName = "Bill", LastName = "Gates", Phone = "9758675309" }
            };
        }
        // GET: Phone
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}