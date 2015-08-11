using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trails5.Models
{
    public class TrailViewModel
    {
        public int Trailnumber { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Time { get; set; }
        public string UserName { get; set; }
    }
}