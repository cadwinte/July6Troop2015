using AngularJSDay23Movies.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularJSDay23Movies.Controllers.API
{
    public class MoviesController : ApiController
    {
        private static ConcurrentStack<Movie> _movies;

        static MoviesController()
        {
            _movies = new ConcurrentStack<Movie>(new List<Movie>
            {
                new Movie { Title = "Fight Club", Director = "Nolan" },
                new Movie { Title = "Inception", Director = "Fincher" },
                new Movie { Title = "Fargo", Director = "Cohen Brothers"}
            });
        }

        public IHttpActionResult Get()
        {
            return Ok(_movies);
        }
    }
}
