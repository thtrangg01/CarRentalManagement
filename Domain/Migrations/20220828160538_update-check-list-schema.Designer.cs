﻿// <auto-generated />
using System;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Domain.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220828160538_update-check-list-schema")]
    partial class updatechecklistschema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.CarEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("dbo.F_GETDATE()");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<bool>("InsuranceOn")
                        .HasColumnType("bit");

                    b.Property<double>("Meter")
                        .HasColumnType("float");

                    b.Property<string>("MeterUnit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<decimal>("OvertimeRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("PickUpCheckListId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<bool>("RequireCheckList")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("Resreved")
                        .HasColumnType("bit");

                    b.Property<int?>("ReturnCheckListId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Number")
                        .IsUnique();

                    b.HasIndex("PickUpCheckListId")
                        .IsUnique()
                        .HasFilter("[PickUpCheckListId] IS NOT NULL");

                    b.HasIndex("ProductId");

                    b.HasIndex("ReturnCheckListId")
                        .IsUnique()
                        .HasFilter("[ReturnCheckListId] IS NOT NULL");

                    b.ToTable("car");
                });

            modelBuilder.Entity("Domain.Entities.CheckList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CarContractDetailId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<double?>("Meter")
                        .HasColumnType("float");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("check_list");
                });

            modelBuilder.Entity("Domain.Entities.CheckListItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CheckListId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsChecked")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("check_list_item");
                });

            modelBuilder.Entity("Domain.Entities.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompleteById")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatorId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("PercentDiscount")
                        .HasColumnType("float");

                    b.Property<string>("RentalAgreement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RentalCondition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Tax")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CompleteById");

                    b.HasIndex("CreatorId");

                    b.HasIndex("CustomerId");

                    b.ToTable("contract");
                });

            modelBuilder.Entity("Domain.Entities.ContractDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<bool>("CheckInDone")
                        .HasColumnType("bit");

                    b.Property<bool>("CheckOutDone")
                        .HasColumnType("bit");

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("MeterLimit")
                        .HasColumnType("float");

                    b.Property<double>("Overtime")
                        .HasColumnType("float");

                    b.Property<decimal>("OvertimeRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PickUpCheckListId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PickUpDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("RealMeter")
                        .HasColumnType("float");

                    b.Property<int>("ReturnCheckListId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SelectedPriceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("contract_detail");
                });

            modelBuilder.Entity("Domain.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("County")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Phone")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Number")
                        .IsUnique();

                    b.ToTable("customer");
                });

            modelBuilder.Entity("Domain.Entities.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("manufacturer");
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BodyType")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("YearOfManufacture")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("product");
                });

            modelBuilder.Entity("Domain.Entities.RentalPrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<double>("MeterLimit")
                        .HasColumnType("float");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("rental_pricce");
                });

            modelBuilder.Entity("Domain.Entities.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("County")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ManagerId")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("StaffNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.ToTable("staff");
                });

            modelBuilder.Entity("Domain.Entities.CarEntity", b =>
                {
                    b.HasOne("Domain.Entities.CheckList", "PickUpCheckList")
                        .WithOne()
                        .HasForeignKey("Domain.Entities.CarEntity", "PickUpCheckListId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.CheckList", "ReturnCheckList")
                        .WithOne()
                        .HasForeignKey("Domain.Entities.CarEntity", "ReturnCheckListId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("PickUpCheckList");

                    b.Navigation("Product");

                    b.Navigation("ReturnCheckList");
                });

            modelBuilder.Entity("Domain.Entities.Contract", b =>
                {
                    b.HasOne("Domain.Entities.Staff", "CompleteBy")
                        .WithMany()
                        .HasForeignKey("CompleteById");

                    b.HasOne("Domain.Entities.Staff", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.HasOne("Domain.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompleteBy");

                    b.Navigation("Creator");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.HasOne("Domain.Entities.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");
                });
#pragma warning restore 612, 618
        }
    }
}
