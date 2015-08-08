using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrailsAngularI.Models
{
    public class Trail
    {
        public int TrailNumber { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime StatusUpdate { get; set; }
    }
}