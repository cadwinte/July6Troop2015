namespace AngularSecurityEuroI.Data.Migrations
{
    using AngularSecurityEuroI.Data.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AngularSecurityEuroI.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AngularSecurityEuroI.Data.ApplicationDbContext context)
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

                userManager.Create(cade, "123456");
                cade = userManager.FindByName("cadeawinter@gmail.com");
            }

            var tom = userManager.FindByName("tom@gmail.com");

            if (tom == null)
            {
                tom = new ApplicationUser
                {
                    UserName = "tom@gmail.com",
                    Email = "tom@gmail.com"
                };

                userManager.Create(tom, "123456");
                tom = userManager.FindByName("tom@gmail.com");
            }



            Car[] cars = new Car[]
            {
                new Car { Make = "Ferrari", Model = "488 GTB", Color = "Red", IsBadass = true, Price = 200000m, UserId = cade.Id },
                new Car { Make = "Porsche", Model = "911 Turbo S", Color = "Silver", IsBadass = true, Price = 190000m, UserId = tom.Id },
                new Car { Make = "Toyta", Model = "Yaris", Color = "Green", IsBadass = false, Price = 19000m, UserId = tom.Id },
                new Car { Make = "Chevy", Model = "El Camino", Color = "Pink", IsBadass = true, Price = 5000m, UserId = cade.Id }
            };

            context.Cars.AddOrUpdate(c => c.Model, cars);

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
