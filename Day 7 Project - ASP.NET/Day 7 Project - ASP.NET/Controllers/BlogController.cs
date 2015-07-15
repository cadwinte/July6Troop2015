using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day_7_Project___ASP.NET.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult GetEntryByDate(DateTime entryDate)
        {
            return Content("You requested the blog entry for date " + entryDate.ToLongDateString());
        }

        public ActionResult GetEntryById(int entryId)
        {
            return Content("You requested the blog entry for ID: " + entryId.ToString());
        }
    }
}