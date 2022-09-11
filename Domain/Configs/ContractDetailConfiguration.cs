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
    public class ContractDetailConfiguration : IEntityTypeConfiguration<ContractDetailEntity>
    {
        public void Configure(EntityTypeBuilder<ContractDetailEntity> builder)
        {
            builder.Ignore(cd => cd.Id)
                .HasKey(cd => new { cd.CarId, cd.ContractId });

            builder.HasOne(c => c.Car)
                .WithMany(cd => cd.ContractDetails)
                .HasForeignKey(cd => cd.CarId);

            builder.HasOne(c => c.Contract)
                .WithMany(cd => cd.ContractDetails)
                .HasForeignKey(cd => cd.ContractId);

            builder.HasMany(c => c.RentalPriceQties)
                .WithOne(rp => rp.ContractDetailEntity)
                .HasForeignKey(rp => new { rp.CarId, rp.ContractId });
        }
    }
}
