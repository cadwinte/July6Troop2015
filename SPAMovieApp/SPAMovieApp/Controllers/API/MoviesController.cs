using SPAMovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SPAMovieApp.Controllers.API
{
    public class MoviesController : ApiController
    {
        private DataContext _db = new DataContext();

        public IHttpActionResult Get()
        {
            return Ok(_db.Movies.ToList());
        }

        public IHttpActionResult Post(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _db.Movies.Add(movie);
                _db.SaveChanges();
                //return Created("/api/movies/", movie);
            }
            return BadRequest(ModelState);
        }
    }
}
