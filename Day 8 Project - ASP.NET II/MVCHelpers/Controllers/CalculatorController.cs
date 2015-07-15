using MVCHelpers.Models;
using ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHelpers.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            Calculator calc = new Calculator
            {
            };



            IndexViewModel vm = new IndexViewModel
            {
                Calc = calc
            };


            return View(vm);
        }
    }
}