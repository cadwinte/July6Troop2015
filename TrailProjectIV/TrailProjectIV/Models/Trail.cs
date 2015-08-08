using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrailProjectIV.Models
{
    public class Trail : AuditObject
    {
        [Key]
        public int TrailId { get; set; }
        public int TrailNumber { get; set; }
        public string TrailName { get; set; }
        public DateTime TrailStatusUpdated { get; set; }

        [ForeignKey("Status")]
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
    }
}