using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Trails5.Data;
using Microsoft.AspNet.Identity;
using Trails5.Models;
using Trails5.Data.Models;

namespace Trails5.Controllers.API
{
    public class TrailsController : ApiController
    {
        private static ApplicationDbContext _db = new ApplicationDbContext();

        public IHttpActionResult Get()
        {
            IList<TrailViewModel> trails = _db.Trails.Select(t => new TrailViewModel
            {
                Trailnumber = t.Trailnumber,
                Name = t.Name,
                Status = t.Status,
                Time = t.Time,
                UserName = t.User.UserName
            }).ToList();

            var userId = User.Identity.GetUserId();

            return Ok(trails);
        }

        //[Authorize(Roles="Admin")]
        public IHttpActionResult Post(TrailViewModel trail)
        {
            Trail dbtrail = new Trail()
            {
                Trailnumber = trail.Trailnumber,
                Name = trail.Name,
                Status = trail.Status,
                Time = trail.Time,
                UserId = User.Identity.GetUserId()
            };

            _db.Trails.Add(dbtrail);

            _db.SaveChanges();

            return Ok(trail);
        }
    }
}