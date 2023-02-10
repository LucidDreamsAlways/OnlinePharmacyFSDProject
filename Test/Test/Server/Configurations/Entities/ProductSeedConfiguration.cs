using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Shared.Domain;

namespace Test.Server.Configurations.Entities
{
    public class ProductSeedConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {   
                    Id = 1,
                    Name = "Panadol",
                    Manufacturer = "Welp Medicine",
                    Price = 5.90,
                    Type = "Tablet",
                    Category = "Fever",
                    DateCreated = DateTime.Now
                },
                new Product
                {
                    Id = 2,
                    Name = "Vicks",
                    Manufacturer = "Welp Medicine",
                    Price = 3.90,
                    Type = "Syrup",
                    Category = "Cough",
                    DateCreated = DateTime.Now
                }
                );

        }
    }
}
