using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTestTenta.Models
{
    public class Product
    {
        public string Name { get; set; }
        public int unitPrice { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
