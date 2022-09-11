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
    public class ContractConfiguration : IEntityTypeConfiguration<ContractEntity>
    {
        public void Configure(EntityTypeBuilder<ContractEntity> builder)
        {
            builder.Property(c => c.Discount)
                .IsRequired(false);

            builder.Property(c => c.PercentDiscount)
                .IsRequired(false);

            builder.Property(c => c.Tax)
                .IsRequired(false);

            builder.Property(c => c.PercentTax)
                .IsRequired(false);
        }
    }
}
