using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ValidationAttributes.Models
{
    public class UserForm
    {
        [DisplayName("User Name")]
        [Remote("ValidateUserName", "UserForm", ErrorMessage = "User Name must be unique!", HttpMethod = "POST")]
        public string UserName { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is required!")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is required!")]
        [MinLength(5, ErrorMessage =  "This is rude, but your Last Name must be at least 5 letters long...")]
        public string LastName { get; set; }

        [DisplayName("Credit Card Number")]
        [CreditCard(ErrorMessage = "Please enter a valid Credit Card Number")]
        public string CreditCard { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter a valid password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]
        [System.ComponentModel.DataAnnotations.Compare("Password")]
        [Required(ErrorMessage = "Please enter a valid password")]
        public string ConfirmPassword { get; set; }

        [DisplayName("Social Security Number")]
        [RegularExpression ("^\\d{3}\\d{2}\\d{4}$", ErrorMessage = "Please enter a valid Social Security Number")]
        public string SSN { get; set; }

        [MaxLength(50, ErrorMessage = "Your comments cannot be longer that 50 characters!")]
        public string Comments { get; set; }
    }
}