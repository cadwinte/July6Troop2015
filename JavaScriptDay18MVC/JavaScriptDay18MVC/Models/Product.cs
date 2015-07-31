﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JavaScriptDay18MVC.Models
{
    public class Product
    {
        [Required(ErrorMessage = "You must enter a product name")]
        public string Name { get; set; }

        [Range(0, 10000, ErrorMessage = "Invalid product price")]
        public decimal Price { get; set; }
    }
}