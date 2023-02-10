using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Shared.Domain;

namespace Test.Server.Configurations.Entities
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
                new Staff
                {
                    Id = 1,
                    Name = "Alex",
                    IC_NO = "S1234567J",
                    Region = "North",
                    Phone_NO = 87617843,
                    Position = "Salesman",
                    Hire_Date = DateTime.Now,
                    Salary = 75000,
                    DateCreated = DateTime.Now
                },
                new Staff
                {
                    Id = 2,
                    Name = "John",
                    IC_NO = "S2634567E",
                    Region = "East",
                    Phone_NO = 97617843,
                    Position = "Senior_Salesman",
                    Hire_Date = DateTime.Now,
                    Salary = 87000,
                    DateCreated = DateTime.Now
                }
                );

        }

    }
}
