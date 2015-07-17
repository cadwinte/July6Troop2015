﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Templates.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public decimal Weight { get; set; }
    }
}