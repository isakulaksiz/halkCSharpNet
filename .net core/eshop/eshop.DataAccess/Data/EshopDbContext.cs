using eshop.Entities;
using Microsoft.EntityFrameworkCore;

namespace eshop.DataAccess.Data
{
    public class EshopDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired();
            base.OnModelCreating(modelBuilder);
        }

    }
}
