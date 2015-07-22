using Day_10_Project_ASP.NET_IV._1.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Day_10_Project_ASP.NET_IV._1.Models
{
    public class DataContext : DbContext
    {
        static DataContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Configuration>());
        }

        public IDbSet<Movie> Movies { get; set; }
        public IDbSet<Genre> Genres { get; set; }
    }
}