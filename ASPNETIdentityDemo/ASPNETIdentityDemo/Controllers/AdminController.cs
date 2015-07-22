using ASPNETIdentityDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETIdentityDemo.Controllers
{
    [Authorize(Roles=Role.ADMINSTRATOR)]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return Content("You're an Admin!!!");
        }
    }
}