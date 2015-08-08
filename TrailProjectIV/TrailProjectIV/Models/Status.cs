using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrailProjectIV.Models
{
    public class Status
    {
        [Key]
        public int StatusId { get; set; }
        [Required]
        public string TrailStatus { get; set; }

        public virtual ICollection<Trail> Trails { get; set; }
    }
}