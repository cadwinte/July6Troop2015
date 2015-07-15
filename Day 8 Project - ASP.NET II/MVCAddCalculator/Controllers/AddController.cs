using MVCAddCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAddCalculator.Controllers
{
    public class AddController : Controller
    {
        // GET: Add
        public ActionResult Index() //Delivers the form to fill out
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(IndexViewModel vm)
        {
            vm.Result = vm.Number1 + vm.Number2;

            return View(vm);
        }
    }
}