using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p => p.Price).IsRequired();

            builder.HasData(
                new Product() { ProductId = 1, CategoryId = 1, ImageUrl = "/images/default.jpg", ProductName = "Computer", Price = 17_000 },
                new Product() { ProductId = 2, CategoryId = 1, ImageUrl = "/images/default.jpg", ProductName = "Keyboard", Price = 1_000 },
                new Product() { ProductId = 3, CategoryId = 1, ImageUrl = "/images/default.jpg", ProductName = "Mouse", Price = 500 },
                new Product() { ProductId = 4, CategoryId = 1, ImageUrl = "/images/default.jpg", ProductName = "Monitor", Price = 7_000 },
                new Product() { ProductId = 5, CategoryId = 2, ImageUrl = "/images/default.jpg", ProductName = "Deck", Price = 1_500 },
                new Product() { ProductId = 6, CategoryId = 2, ImageUrl = "/images/default.jpg", ProductName = "Book", Price = 25 },
                new Product() { ProductId = 7, CategoryId = 2, ImageUrl = "/images/default.jpg", ProductName = "Pen", Price = 15 }
            );
        }
    }
}