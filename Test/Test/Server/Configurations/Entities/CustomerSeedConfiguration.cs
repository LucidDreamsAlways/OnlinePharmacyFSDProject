using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Shared.Domain;

namespace Test.Server.Configurations.Entities
{
    public class CustomerSeedConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer
                {
                    Id = 1,
                    Name = "Nagul",
                    Phone_NO = 97617843,
                    Address = "Blk 409A, 791409",
                    Email = "nagul@gmail.com",
                    DateCreated = DateTime.Now
                },
                new Customer
                {
                    Id = 2,
                    Name = "Nicholas",
                    Phone_NO = 83659024,
                    Address = "Blk 420, 420309",
                    Email = "nicholas@gmail.com",
                    DateCreated = DateTime.Now
                }
                );

        }
    }
}
