using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ManyToManyEasy.Models
{
    public class StudentCourse
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        [InverseProperty("Courses")] //Name of virtual property in Student Class
        public virtual Student Student { get; set; }

        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        [InverseProperty("Students")] //Name of virtual property in Course Class
        public virtual Course Course { get; set; }

        public int Grade { get; set; }
    }
}