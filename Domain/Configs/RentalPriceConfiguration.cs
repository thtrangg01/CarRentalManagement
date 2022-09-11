using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Configs
{
    public class RentalPriceConfiguration : IEntityTypeConfiguration<RentalPrice>
    {
        public void Configure(EntityTypeBuilder<RentalPrice> builder)
        {
            builder.HasOne(rp => rp.CarEntity)
                .WithMany(c => c.RentalPrices)
                .HasForeignKey(rp => rp.CarId);
        }
    }
}
