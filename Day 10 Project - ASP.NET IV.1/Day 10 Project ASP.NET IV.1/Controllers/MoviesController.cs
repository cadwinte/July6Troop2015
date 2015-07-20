using Day_10_Project_ASP.NET_IV._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day_10_Project_ASP.NET_IV._1.Controllers
{
    public class MoviesController : Controller
    {
        private DataContext _db = new DataContext();

        // GET: Movies
        public ActionResult Index()
        {
            var movies = from m in _db.Movies select m;

            return View(movies.ToList());
        }
    }
}