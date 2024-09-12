﻿// <auto-generated />
using System;
using Bill_system_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bill_system_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240912183142_Test")]
    partial class Test
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bill_system_API.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Bill_system_API.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Apple"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Samsung"
                        });
                });

            modelBuilder.Entity("Bill_system_API.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Bill_system_API.Models.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BillNumber")
                        .HasColumnType("int");

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<TimeOnly>("EndTime")
                        .HasColumnType("time");

                    b.Property<double>("PaidUp")
                        .HasColumnType("float");

                    b.Property<double>("PercentageDiscount")
                        .HasColumnType("float");

                    b.Property<TimeOnly>("StartTime")
                        .HasColumnType("time");

                    b.Property<double>("ValueDiscount")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("Bill_system_API.Models.InvoiceItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<int?>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<double>("SellingPrice")
                        .HasColumnType("float");

                    b.Property<double>("TotalValue")
                        .HasColumnType("float");

                    b.Property<string>("itemId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("itemId");

                    b.ToTable("InvoiceItems");
                });

            modelBuilder.Entity("Bill_system_API.Models.Item", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AvailableAmount")
                        .HasColumnType("int");

                    b.Property<double>("BuyingPrice")
                        .HasColumnType("float");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SellingPrice")
                        .HasColumnType("float");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<int>("UnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("TypeId");

                    b.HasIndex("UnitId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Bill_system_API.Models.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Types");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyId = 0,
                            Name = "Elctronics"
                        });
                });

            modelBuilder.Entity("Bill_system_API.Models.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Units");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Item"
                        },
                        new
                        {
                            Id = 2,
                            Name = "m"
                        });
                });

            modelBuilder.Entity("Bill_system_API.Models.Invoice", b =>
                {
                    b.HasOne("Bill_system_API.Models.Client", "Client")
                        .WithMany("Invoices")
                        .HasForeignKey("ClientId");

                    b.HasOne("Bill_system_API.Models.Employee", "Employee")
                        .WithMany("Invoices")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Client");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Bill_system_API.Models.InvoiceItem", b =>
                {
                    b.HasOne("Bill_system_API.Models.Invoice", "Invoice")
                        .WithMany("InvoiceItems")
                        .HasForeignKey("InvoiceId");

                    b.HasOne("Bill_system_API.Models.Item", "item")
                        .WithMany()
                        .HasForeignKey("itemId");

                    b.Navigation("Invoice");

                    b.Navigation("item");
                });

            modelBuilder.Entity("Bill_system_API.Models.Item", b =>
                {
                    b.HasOne("Bill_system_API.Models.Company", "Company")
                        .WithMany("Items")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bill_system_API.Models.Type", "Type")
                        .WithMany("Items")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bill_system_API.Models.Unit", "Unit")
                        .WithMany("Items")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Type");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("Bill_system_API.Models.Type", b =>
                {
                    b.HasOne("Bill_system_API.Models.Company", "Company")
                        .WithMany("Types")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Bill_system_API.Models.Client", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("Bill_system_API.Models.Company", b =>
                {
                    b.Navigation("Items");

                    b.Navigation("Types");
                });

            modelBuilder.Entity("Bill_system_API.Models.Employee", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("Bill_system_API.Models.Invoice", b =>
                {
                    b.Navigation("InvoiceItems");
                });

            modelBuilder.Entity("Bill_system_API.Models.Type", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Bill_system_API.Models.Unit", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
