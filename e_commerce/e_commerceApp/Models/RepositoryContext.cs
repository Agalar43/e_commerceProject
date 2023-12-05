using Microsoft.EntityFrameworkCore;

namespace e_commerceApp.Models
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new Product() { ProductID = 1, ProductName = "Bilgisayar", ProductDescription = "son model işlemciye sahip", ProductRanking = "0", unitPrice = 1000, ImageUrl = "null", Stock = 10, CategoryID = 1 },
                new Product() { ProductID = 2, ProductName = "Telefon", ProductDescription = "son model işlemciye sahip", ProductRanking = "0", unitPrice = 1000, ImageUrl = "null", Stock = 10, CategoryID = 1 }
            );
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category() { CategoryID = 1, CategoryName = "Elektronik" },
                new Category() { CategoryID = 2, CategoryName = "Book" }
            );
        }
    }
}