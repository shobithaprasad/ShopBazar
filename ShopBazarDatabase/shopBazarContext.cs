using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ShopBazar.Entities;

namespace ShopBazarDatabase
{
    public class shopBazarContext:DbContext
    {
        public shopBazarContext():base("CS")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
