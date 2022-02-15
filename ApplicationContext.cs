using Microsoft.EntityFrameworkCore;
using template_csharp_reviews_site.Models;

namespace template_csharp_reviews_site
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        const string CONNECTION_STRING = "Server=(localdb)\\mssqllocaldb; Database=Blog; Trusted_connection=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CONNECTION_STRING);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Brand = "Samsung",
                Model = "Galaxy",
                OSVer = "Android 10",
                Price = 800.00,
                ReleaseDate = System.DateTime.Now
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Brand = "Apple",
                Model = "iPhone 13 Pro Max",
                OSVer = "iOS",
                Price = 1099.00,
                ReleaseDate = System.DateTime.Now
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Brand = "Motorola",
                Model = "Razr",
                OSVer = "Android 9",
                Price = 499.00,
                ReleaseDate = System.DateTime.Now
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Brand = "GooglePhone",
                Model = "Pixel 6 Pro",
                OSVer = "Android 12",
                Price = 599.00,
                ReleaseDate = System.DateTime.Now
            });
        }
    }
}
