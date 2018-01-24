using Microsoft.AspNetCore.Identity;
using MVCTestTenta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTestTenta.Data
{
    public class DbSeed
    {
        public static void Seed(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            var CocaCola = new Product { Name = "CocaCola", UnitPrice = 6, ReleaseDate = DateTime.ParseExact("2018-12-01", "yyyy-mm-dd", null) };
            var Chips = new Product { Name = "Chips", UnitPrice = 20, ReleaseDate = DateTime.ParseExact("2018-12-01", "yyyy-mm-dd", null) };
            var IceCream = new Product { Name = "IceCream", UnitPrice = 12, ReleaseDate = DateTime.ParseExact("2018-12-01", "yyyy-mm-dd", null) };
            context.Product.Add(CocaCola);
            context.Product.Add(Chips);
            context.Product.Add(IceCream);
            context.SaveChanges();

            var user = new ApplicationUser { UserName = "admin@inter.net" };
            var result = userManager.CreateAsync(user, "Abc123!").Result;
            var admin = new IdentityRole { Name = "admin" };
            var role = roleManager.CreateAsync(admin).Result;
            userManager.AddToRoleAsync(user, "admin");

            user = new ApplicationUser { UserName = "student@inter.net" };
            result = userManager.CreateAsync(user, "Abc123!").Result;
        }
    }
}
