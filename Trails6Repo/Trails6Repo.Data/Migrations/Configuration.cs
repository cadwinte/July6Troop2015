namespace Trails6Repo.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Trails6Repo.Data.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Trails6Repo.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Trails6Repo.Data.ApplicationDbContext context)
        {
            UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(context);
            UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(userStore);

            var cade = userManager.FindByName("cadeawinter@gmail.com");

            if (cade == null)
            {
                cade = new ApplicationUser
                {
                    UserName = "cadeawinter@gmail.com",
                    Email = "cadeawinter@gmail.com"
                };

                userManager.Create(cade, "Lirby32Caw");
                cade = userManager.FindByName("cadeawinter@gmail.com");
            }

            var trails = new Trail[]
            {
                new Trail { Trailnumber = 1, Name = "Givens, Spicer & Lowery Trail", Status = "Clear", Time = "August 8th, 2015, 5:00 am", UserId = cade.Id },
                new Trail { Trailnumber = 2, Name = "Lighthouse Trail", Status = "Clear", Time = "August 8th, 2015, 5:00 am", UserId = cade.Id },
                new Trail { Trailnumber = 3, Name = "Capitol Peak Trail", Status = "Clear", Time = "August 8th, 2015, 5:00 am", UserId = cade.Id },
                new Trail { Trailnumber = 4, Name = "Little Fox Canyon Trail", Status = "Clear", Time = "August 8th, 2015, 5:00 am", UserId = cade.Id }
            };

            context.Trails.AddOrUpdate(t => t.Name, trails);

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
