using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Eshop.Models
{
    public class EshopContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Style> Styles { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Technology> Technologies { get; set; }
    }
}