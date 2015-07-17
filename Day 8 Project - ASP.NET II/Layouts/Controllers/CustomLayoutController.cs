using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Layouts.Controllers
{
    public class CustomLayoutController : Controller
    {
        // GET: CustomLayout
        public ActionResult Index()
        {
            return View();
        }
    }
}