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
    public class CarConfiguration : IEntityTypeConfiguration<CarEntity>
    {
        public void Configure(EntityTypeBuilder<CarEntity> builder)
        {
            builder.ToTable("car");

            builder.HasIndex(c => c.Number).IsUnique();

            builder.Property(c => c.RequireCheckList)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(c => c.PickUpCheckListId)
                .IsRequired(false);

            builder.Property(c => c.ReturnCheckListId)
                .IsRequired(false);

            builder.Property<DateTime>("CreatedAt");
            builder.Property<DateTime>("UpdatedAt");

            builder.HasOne(c => c.PickUpCheckList)
                .WithOne()
                .HasForeignKey<CarEntity>(c => c.PickUpCheckListId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.ReturnCheckList)
                .WithOne()
                .HasForeignKey<CarEntity>(c => c.ReturnCheckListId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
