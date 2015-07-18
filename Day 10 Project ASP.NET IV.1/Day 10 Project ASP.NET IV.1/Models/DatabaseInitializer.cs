using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Day_10_Project_ASP.NET_IV._1.Models
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var movies = new List<Movie>
            {
                new Movie { Title = "Star Wars", Director = "Lucas" },
                new Movie { Title = "Momento", Director = "Nolan" },
                new Movie { Title = "King Kong", Director = "Jackson" }
            };

            movies.ForEach(m => context.Movies.Add(m));

            //foreach(Movie m in movies) ////other way to write the foreach loop
            //{
            //    context.Movies.Add(m);
            //}
        }
    }
}