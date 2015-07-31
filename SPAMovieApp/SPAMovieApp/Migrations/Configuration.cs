namespace SPAMovieApp.Migrations
{
    using SPAMovieApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SPAMovieApp.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SPAMovieApp.Models.DataContext context)
        {
            var movies = new Movie[]
            {
                new Movie { Title = "Star Wars", Director = "Lucas" },
                new Movie { Title = "Inception", Director = "Nolan" },
                new Movie { Title = "Lord of the Rings", Director = "Jackson" }
            };

            context.Movies.AddOrUpdate(m => m.Title, movies);

            //context.Cars.AddOrUpdate(m => m.Model, cars);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
