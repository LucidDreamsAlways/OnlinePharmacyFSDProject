using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Shared.Domain;

namespace Test.Server.Configurations.Entities
{
    public class OrderSeedConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(
                new Order
                {
                    Id = 1,
                    OrderDateTime = DateTime.Now,
                    OrderDeliveryDate = DateTime.Today.AddDays(1),
                    Order_Qty = 4,
                    Payment_Type = "VISA",
                    CustomerId = 1,
                    ProductId = 1
                }
                
                );

        }
    }
}
