namespace TrailProjectIV.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TrailProjectIV.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TrailProjectIV.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TrailProjectIV.Models.DataContext context)
        {
            var trails = new Trail[]
            {
                new Trail { TrailNumber = 1, TrailName = "Givens, Spicer & Lowry Trail", TrailStatusUpdated = DateTime.Now, StatusId = 1 },
                new Trail { TrailNumber = 2, TrailName = "Lighthouse Trail", TrailStatusUpdated = DateTime.Now, StatusId = 1 },
                new Trail { TrailNumber = 3, TrailName = "Capitol Peak Trail", TrailStatusUpdated = DateTime.Now, StatusId = 1 },
                new Trail { TrailNumber = 4, TrailName = "Little Fox Canyon Trail", TrailStatusUpdated = DateTime.Now, StatusId = 1 }
            };

            context.Trails.AddOrUpdate(t => t.TrailNumber, trails);
        }
    }
}
