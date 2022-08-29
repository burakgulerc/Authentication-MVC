using MVCAuthentication_Tekrar3.DesignPatterns.StrategyPattern;
using MVCAuthentication_Tekrar3.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCAuthentication_Tekrar3.Models.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyConnectionWinAuth")
        {
            Database.SetInitializer(new MyInit());
        }

        public DbSet<AppUser> AppUsers { get; set; }
    }
}