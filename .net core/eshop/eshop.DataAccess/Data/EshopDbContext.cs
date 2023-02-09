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
            modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired()
                                                                .HasMaxLength(250);


            modelBuilder.Entity<Product>().HasOne(p => p.Category)
                                          .WithMany(c => c.Products)
                                          .HasForeignKey(p => p.CategoryId)
                                          .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Category>().HasData(
                  new Category { Id = 1, Name = "Bilgisayar" },
                  new Category { Id = 2, Name = "Ses Sistemleri" },
                  new Category { Id = 3, Name = "Smart TV" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, CategoryId = 1, Description = "Dell XPS 13 Açıklama", Name = "Dell XPS 13", DiscountRate = 0.10, Price = 30000, ImageUrl = "https://cdn.dsmcdn.com/ty709/product/media/images/20230131/17/270762905/660823832/1/1_org.jpg" },

                  new Product { Id = 2, CategoryId = 2, Description = "5+1 Ses sistemi Açıklama", Name = "Sony  5+1 Ses sistemi", DiscountRate = 0.10, Price = 20000, ImageUrl = "https://cdn.dsmcdn.com/ty709/product/media/images/20230131/17/270762905/660823832/1/1_org.jpg" },

                  new Product { Id = 3, CategoryId = 3, Description = "Philips Açıklama", Name = "Philips 4k", DiscountRate = 0.15, Price = 42000, ImageUrl = "https://cdn.dsmcdn.com/ty709/product/media/images/20230131/17/270762905/660823832/1/1_org.jpg" }
                );



            base.OnModelCreating(modelBuilder);
        }

        public EshopDbContext(DbContextOptions<EshopDbContext> options) : base(options)
        {

        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("çok gizli ADRES ve ŞİFREler");


        //}

    }
}
