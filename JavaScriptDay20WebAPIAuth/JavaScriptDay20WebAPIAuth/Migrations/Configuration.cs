namespace JavaScriptDay20WebAPIAuth.Migrations
{
    using JavaScriptDay20WebAPIAuth.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<JavaScriptDay20WebAPIAuth.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(JavaScriptDay20WebAPIAuth.Models.ApplicationDbContext context)
        {
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            var cade = userManager.FindByName("cadeawinter@gmail.com");

            if (cade == null)
            {
                cade = new ApplicationUser
                {
                    UserName = "cadeawinter@gmail.com",
                    Email = "cadeawinter@gmail.com"
                };

                userManager.Create(cade, "123456");
            }
        }
    }
}
