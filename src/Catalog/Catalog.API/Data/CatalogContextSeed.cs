using System;
using System.Collections.Generic;
using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();

            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }

        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product 
                { 
                    Name = "Iphone 12", 
                    Summary = "asd", 
                    Description = "Asd",
                    ImageFile = "product-1.png",
                    Price = 950.00M,
                    Category = "Smartphone"
                },

                new Product
                {
                    Name = "Galaxy S21",
                    Summary = "asd",
                    Description = "Asd",
                    ImageFile = "product-2.png",
                    Price = 950.00M,
                    Category = "Smartphone"
                },

                new Product
                {
                    Name = "Oneplus 8 Pro",
                    Summary = "asd",
                    Description = "Asd",
                    ImageFile = "product-3.png",
                    Price = 950.00M,
                    Category = "Smartphone"
                },

                new Product
                {
                    Name = "Pixel 5",
                    Summary = "asd",
                    Description = "Asd",
                    ImageFile = "product-4.png",
                    Price = 950.00M,
                    Category = "Smartphone"
                },



            };
        }
    }
}
