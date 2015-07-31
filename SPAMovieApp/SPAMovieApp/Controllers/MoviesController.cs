using SPAMovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace SPAMovieApp.Controllers
{
    public class MoviesController : Controller
    {
        private DataContext _db = new DataContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetMovies()
        {
            var movies = _db.Movies;

            return Json(movies, JsonRequestBehavior.AllowGet);
        } 
    }
}