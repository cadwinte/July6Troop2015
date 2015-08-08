using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrailProjectIV.Models
{
    public class AuditObject
    {
        public string CreatedUserId { get; set; }
        public string UpdatedUserId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime TimeUpdated { get; set; }
        public bool IsDeleted { get; set; }
    }
}