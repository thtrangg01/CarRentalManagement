using Domain.Configs;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Domain
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { set; get; }
        public DbSet<Staff> Staffs { set; get; }
        public DbSet<CarEntity> Cars { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<RentalPrice> RentalPrices { get; set; }
        public DbSet<ContractEntity> Contracts { get; set; }
        public DbSet<ContractDetailEntity> ContractDetails { get; set; }
        public DbSet<CheckList> CheckLists { get; set; }
        public DbSet<CheckListItem> CheckListItems { get; set; }
        public DbSet<Manufacturer> Manufacturers { set; get; }
        public DbSet<Payment> Payments { set; get; }
        public DbSet<SignIn> SignIns { set; get; }
        public DbSet<RentalPriceQty> RentalPriceQties { get; set; }

        public const string connectionString = @"
                                Data Source = cuongbuilh.xyz,1433; 
                                Initial Catalog = car-rental-management; 
                                User ID = thtrang; 
                                Password=@Thutrang2209";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString, o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery));
            optionsBuilder.UseLoggerFactory(GetLoggerFactory());
            optionsBuilder.LogTo(
                message => Debug.WriteLine(message),
                new[] { DbLoggerCategory.Database.Command.Name },
                LogLevel.Information);
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Staff>()
                .HasOne(s => s.SignIn)
                .WithOne(si => si.Staff)
                .HasForeignKey<SignIn>(si => si.StaffId);

            #region CustomerModelBuilder
            modelBuilder.Entity<Customer>().HasIndex(c => c.Number).IsUnique();

            modelBuilder.Entity<Customer>()
                .Property(c => c.CreatedAt)
                .ValueGeneratedOnAdd();
            //.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Customer>()
                .Property(c => c.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate();

            #endregion


            #region CarModelBuilder

            modelBuilder.ApplyConfiguration(new CarConfiguration());
            modelBuilder.ApplyConfiguration(new CheckListConfiguration());
            modelBuilder.ApplyConfiguration(new CheckListItemConfiguration());
            modelBuilder.ApplyConfiguration(new ContractDetailConfiguration());
            modelBuilder.ApplyConfiguration(new RentalPriceConfiguration());
            modelBuilder.ApplyConfiguration(new ContractConfiguration());
            #endregion
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseEntity && (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                entityEntry.Property("UpdatedAt").CurrentValue = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    entityEntry.Property("CreatedAt").CurrentValue = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }

        private ILoggerFactory GetLoggerFactory()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging(builder =>
                    builder.AddConsole()
                            .AddFilter(DbLoggerCategory.Database.Command.Name, LogLevel.Information));

            return serviceCollection.BuildServiceProvider()
                  .GetService<ILoggerFactory>();
        }
    }
}
