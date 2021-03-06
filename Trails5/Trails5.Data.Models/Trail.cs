﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trails5.Data.Models
{
    public class Trail
    {
        [Key]
        public int Id { get; set; }
        public int Trailnumber { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Time { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
