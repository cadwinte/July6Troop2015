using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TrailsIII.Models;

namespace TrailsIII.Controllers.API
{
    public class TrailsController : ApiController
    {
        private static IGenericRepository _repo;

        public TrailsController()
        {

        }

        public IHttpActionResult Get()
        {
            return Ok(_repo);
        }
    }
}
