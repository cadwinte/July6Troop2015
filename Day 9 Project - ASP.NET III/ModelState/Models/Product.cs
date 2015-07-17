using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadeModelState.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Product Name is required!")]
        [MaxLength(20, ErrorMessage = "Product Name is too long!")]
        [Remote("ValidateProduct", "Products", ErrorMessage = "Product Name must be unique!", HttpMethod = "POST")]
        public string Name { get; set; }
        [Range(0, 100, ErrorMessage = "Price must be greater than zero, and less than 100!")]
        public decimal Price { get; set; }
    }
}