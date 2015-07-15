using Day_7_Project___ASP.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day_7_Project___ASP.NET.Controllers
{
    public class MoviesController : Controller //Controller class is inhereted
    {

 
        private Repository _repo = new Repository();

        public ActionResult IWantMovies(string IWantMovies)
        {
            IList<Movie> movies = _repo.ListMovies(); 
            return View(movies); //Don't forget to add a view!!!
        }


        // GET: Movies
        public ActionResult Index() //Index() is an action (cs.HTML)
        {
            IList<Movie> movies = _repo.ListMovies();

            return View(movies); //View is a method, inherited from Controller
        }
    }
}