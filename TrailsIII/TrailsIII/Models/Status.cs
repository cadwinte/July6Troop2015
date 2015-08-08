using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrailsIII.Models
{
    public class Status
    {
        public int Id { get; set; }
        public string TrailStatus { get; set; }

        public virtual ICollection<Trail> Trails { get; set; }
    }
}