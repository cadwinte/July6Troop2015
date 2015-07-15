using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day_7_Project___ASP.NET.Models
{
    abstract public class Pro
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public object OnSale { get; set; }
    }

    public class NewPro : Pro { }

    public class ProOS: Pro
    {
        public string OnSale { get; set; }
    }
}