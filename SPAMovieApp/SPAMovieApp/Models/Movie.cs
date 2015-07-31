using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPAMovieApp.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [MaxLength(10, ErrorMessage = "Director Name cannot be more than 10 characters")]
        public string Director { get; set; }
    }
}