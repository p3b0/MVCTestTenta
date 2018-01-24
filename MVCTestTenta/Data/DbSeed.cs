using MVCTestTenta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTestTenta.Data
{
    public class DbSeed
    {
        public static void Seed(ApplicationDbContext context)
        {
            var CocaCola = new Product { Name = "CocaCola", UnitPrice = 6, ReleaseDate = DateTime.ParseExact("2018-12-01", "yyyy-mm-dd", null) };
            context.Product.Add(CocaCola);
            context.SaveChanges();
        }
    }
}
