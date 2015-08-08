using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TrailsIII.Models
{
    public class DataContext : DbContext 
    {
        public IDbSet<Trail> Trails { get; set; }
        public IDbSet<Status> Statuses { get; set; }
    }
}