using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TrailsAngularI.Models;

namespace TrailsAngularI.Controllers.API
{
    public class TrailsController : ApiController
    {
        private static ConcurrentStack<Trail> _trails;

        static TrailsController()
        {
            _trails = new ConcurrentStack<Trail>(new List<Trail>
            {
                new Trail { TrailNumber = 1, Name = "GSL Trail", Status = "Clear", StatusUpdate = DateTime.Now },
                new Trail { TrailNumber = 2, Name = "Lighthouse Trail", Status = "Clear", StatusUpdate = DateTime.Now },
                new Trail { TrailNumber = 3, Name = "Capitol Peak Trail", Status = "Clear", StatusUpdate = DateTime.Now },
                new Trail { TrailNumber = 4, Name = "Little Fox Canyon Trail", Status = "Clear", StatusUpdate = DateTime.Now }
            });
        }

        public IHttpActionResult Get()
        {
            return Ok(_trails);
        }

        public IHttpActionResult Post(Trail trail)
        {
            _trails.Push(trail);
            return Ok();
        }
    }
}
