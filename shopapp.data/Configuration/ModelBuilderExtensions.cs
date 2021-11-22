using Microsoft.EntityFrameworkCore;
using shopapp.entity;

namespace shopapp.data.Configuration
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Product>().HasData(
                new Product() { ProductId = 1, Name = "Samsung s21", Url = "samsung-s21", Price = 10000, ImageUrl = "1.jpg", Description = "çok iyi telefon", IsApproved = true },
                new Product() { ProductId = 2, Name = "Samsung s22", Url = "samsung-s22", Price = 11000, ImageUrl = "2.jpg", Description = "çok iyi telefon", IsApproved = true },
                new Product() { ProductId = 3, Name = "Samsung s23", Url = "samsung-s23", Price = 12000, ImageUrl = "3.jpg", Description = "çok iyi telefon", IsApproved = false },
                new Product() { ProductId = 4, Name = "Samsung s24", Url = "samsung-s24", Price = 13000, ImageUrl = "4.jpg", Description = "çok iyi telefon", IsApproved = false },
                new Product() { ProductId = 5, Name = "Samsung s25", Url = "samsung-s25", Price = 14000, ImageUrl = "5.jpg", Description = "çok iyi telefon", IsApproved = true },
                new Product() { ProductId = 6, Name = "Samsung s26", Url = "samsung-s26", Price = 15000, ImageUrl = "6.jpg", Description = "çok iyi telefon", IsApproved = true }
            );

            builder.Entity<Category>().HasData(
                new Category() { CategoryId = 1, Name = "Telefon", Url = "telefon" },
                new Category() { CategoryId = 2, Name = "Bilgisayar", Url = "bilgisayar" },
                new Category() { CategoryId = 3, Name = "Tablet", Url = "tablet" },
                new Category() { CategoryId = 4, Name = "Beyaz Eşya", Url = "beyaz-esya" }
            );

            builder.Entity<ProductCategory>().HasData(
                new ProductCategory() { ProductId = 1, CategoryId = 1 },
                new ProductCategory() { ProductId = 2, CategoryId = 2 },
                new ProductCategory() { ProductId = 3, CategoryId = 3 },
                new ProductCategory() { ProductId = 4, CategoryId = 2 },
                new ProductCategory() { ProductId = 5, CategoryId = 3 },
                new ProductCategory() { ProductId = 6, CategoryId = 1 }
            );
        }
    }
}