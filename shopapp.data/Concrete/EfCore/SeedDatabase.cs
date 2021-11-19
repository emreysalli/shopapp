using System.Linq;
using Microsoft.EntityFrameworkCore;
using shopapp.entity;

namespace shopapp.data.Concrete.EfCore
{
    public class SeedDatabase
    {
        public static void Seed()
        {
            // var context = new ShopContext();
            // if (context.Database.GetPendingMigrations().Count() == 0)
            // {
            //     if (context.Categories.Count() == 0)
            //     {
            //         context.Categories.AddRange(Categories);
            //     }

            //     if (context.Products.Count() == 0)
            //     {
            //         context.Products.AddRange(Products);
            //         context.AddRange(ProductCategories);
            //     }
            // }
            // context.SaveChanges();
        }

        private static Category[] Categories ={
            new Category(){Name="Telefon",Url="telefon"},
            new Category(){Name="Bilgisayar",Url="bilgisayar"},
            new Category(){Name="Tablet",Url="tablet"},
            new Category(){Name="Beyaz Eşya",Url="beyaz-esya"}
        };

        private static Product[] Products ={
            new Product(){Name="Samsung s21",Url="samsung-s21",Price=10000,ImageUrl="1.jpg",Description="çok iyi telefon",IsApproved=true},
            new Product(){Name="Samsung s22",Url="samsung-s22",Price=11000,ImageUrl="2.jpg",Description="çok iyi telefon",IsApproved=true},
            new Product(){Name="Samsung s23",Url="samsung-s23",Price=12000,ImageUrl="3.jpg",Description="çok iyi telefon",IsApproved=false},
            new Product(){Name="Samsung s24",Url="samsung-s24",Price=13000,ImageUrl="4.jpg",Description="çok iyi telefon",IsApproved=false},
            new Product(){Name="Samsung s25",Url="samsung-s25",Price=14000,ImageUrl="5.jpg",Description="çok iyi telefon",IsApproved=true},
            new Product(){Name="Samsung s26",Url="samsung-s26",Price=15000,ImageUrl="6.jpg",Description="çok iyi telefon",IsApproved=true}
        };

        private static ProductCategory[] ProductCategories ={
            new ProductCategory(){Product=Products[0],Category=Categories[0]},
            new ProductCategory(){Product=Products[0],Category=Categories[2]},
            new ProductCategory(){Product=Products[1],Category=Categories[0]},
            new ProductCategory(){Product=Products[1],Category=Categories[2]},
            new ProductCategory(){Product=Products[2],Category=Categories[0]},
            new ProductCategory(){Product=Products[2],Category=Categories[2]}
        };
    }
}