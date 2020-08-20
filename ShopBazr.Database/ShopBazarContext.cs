using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ShopBazar.Entities;


namespace ShopBazr.Database
{
    public class ShopBazarContext :DbContext
    {
        public ShopBazarContext():base("ShopBazarCS")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
