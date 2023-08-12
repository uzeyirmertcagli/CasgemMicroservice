﻿// <auto-generated />
using System;
using CasgemMicroservice.Services.Order.Infrastructure.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CasgemMicroservice.Services.Order.Infra.Persistance.Migrations
{
    [DbContext(typeof(OrderContext))]
    partial class OrderContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CasgemMicroservice.Services.Order.Core.Domain.Entities.Address", b =>
                {
                    b.Property<int>("AddressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressID"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("CasgemMicroservice.Services.Order.Core.Domain.Entities.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderDetailID"), 1L, 1);

                    b.Property<int>("OrderingID")
                        .HasColumnType("int");

                    b.Property<int>("ProductAmount")
                        .HasColumnType("int");

                    b.Property<string>("ProductID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailID");

                    b.HasIndex("OrderingID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("CasgemMicroservice.Services.Order.Core.Domain.Entities.Ordering", b =>
                {
                    b.Property<int>("OrderingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderingID"), 1L, 1);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderingID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CasgemMicroservice.Services.Order.Core.Domain.Entities.OrderDetail", b =>
                {
                    b.HasOne("CasgemMicroservice.Services.Order.Core.Domain.Entities.Ordering", "Ordering")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ordering");
                });

            modelBuilder.Entity("CasgemMicroservice.Services.Order.Core.Domain.Entities.Ordering", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
