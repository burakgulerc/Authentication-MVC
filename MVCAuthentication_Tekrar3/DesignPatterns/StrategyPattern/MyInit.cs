using MVCAuthentication_Tekrar3.Models.Context;
using MVCAuthentication_Tekrar3.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCAuthentication_Tekrar3.DesignPatterns.StrategyPattern
{
    public class MyInit : CreateDatabaseIfNotExists<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            AppUser ap = new AppUser
            {
                UserName = "Burak",
                Password = "123",
                Role = Models.Enums.UserRole.Admin,
            };

            AppUser ap2 = new AppUser
            {
                UserName = "Cagri",
                Password = "qwe",
                Role = Models.Enums.UserRole.Member
            };

            context.AppUsers.Add(ap);
            context.AppUsers.Add(ap2);
            context.SaveChanges();  
        }
    }
}