using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Layouts.Controllers
{
    public class BannerAddController : Controller
    {
        // GET: BannerAdd
        [ChildActionOnly]
        public ActionResult GetAdd()
        {

            var adText = "Drink a Vanilla Latte!";
            if (DateTime.Now.Hour > 12)
            {
                adText = "Drink a cup of tea!";
            }

            return PartialView("_BannerAdd", adText);
        }
    }
}