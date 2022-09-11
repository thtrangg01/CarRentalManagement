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
    public class CheckListConfiguration : IEntityTypeConfiguration<CheckList>
    {
        public void Configure(EntityTypeBuilder<CheckList> builder)
        {
            //builder.HasNoKey();
            //builder.HasOne(chl => chl.Car)
            //    .WithOne(c => c.PickUpCheckList)
            //    .HasForeignKey<CarEntity>(c => c.PickUpCheckListId)
            //    .OnDelete(DeleteBehavior.ClientSetNull);

            builder.Property(c => c.CarContractDetailId)
                .IsRequired(false);

            builder.Property(c => c.Meter)
                .IsRequired(false);

            builder.Property(c => c.Note)
                .IsRequired(false);
        }
    }
}
