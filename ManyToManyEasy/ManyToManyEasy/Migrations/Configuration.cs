namespace ManyToManyEasy.Migrations
{
    using ManyToManyEasy.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ManyToManyEasy.Models.SchoolDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ManyToManyEasy.Models.SchoolDbContext context)
        {
            //Seed Students
            var students = new Student[]
            {
                new Student { LastName = "Winter", FirstName = "Cade" },
                new Student { LastName = "Schrute", FirstName = "Dwight" }
            };

            context.Students.AddOrUpdate(s => new { s.FirstName, s.LastName }, students);
            context.SaveChanges();

            //Seed Courses
            var courses = new Course[]
            {
                new Course { Code = "MATH1405", Name = "Calculus I" },
                new Course { Code = "HIST4307", Name = "Tsarist Russia" },
                new Course { Code = "BIO2455", Name = "Microbiology II" }
            };

            context.Courses.AddOrUpdate(c => c.Code, courses);
            context.SaveChanges();


            var cade = context.Students.FirstOrDefault(s => s.FirstName == "Cade");
            var dwight = context.Students.FirstOrDefault(s => s.FirstName == "Dwight");

            if (!cade.Courses.Any(c => c.CourseId == courses[0].Id))
            {
                cade.Courses.Add(new StudentCourse
                    {
                        CourseId = courses[0].Id
                    });
            }

            if (!cade.Courses.Any(c => c.CourseId == courses[1].Id))
            {
                cade.Courses.Add(new StudentCourse
                    {
                        CourseId = courses[1].Id
                    });
            }

            StudentCourse course = cade.Courses.FirstOrDefault(c => c.CourseId == courses[0].Id);
            course.Grade = 100;
        }
    }
}
