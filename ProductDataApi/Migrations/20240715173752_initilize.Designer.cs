﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductDataApi.Data;

#nullable disable

namespace ProductDataApi.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20240715173752_initilize")]
    partial class initilize
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProductDataApi.Data.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Datetime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Datetime = new DateTime(2024, 7, 15, 21, 37, 52, 96, DateTimeKind.Local).AddTicks(4226),
                            Description = "bla bla bla",
                            Name = "iphone11",
                            Price = 300m,
                            ProductType = 1
                        },
                        new
                        {
                            Id = 2,
                            Datetime = new DateTime(2024, 7, 15, 21, 37, 52, 96, DateTimeKind.Local).AddTicks(4236),
                            Description = "bla bla bla",
                            Name = "iphone13",
                            Price = 400m,
                            ProductType = 1
                        },
                        new
                        {
                            Id = 3,
                            Datetime = new DateTime(2024, 7, 15, 21, 37, 52, 96, DateTimeKind.Local).AddTicks(4237),
                            Description = "bla bla bla",
                            Name = "iphone14",
                            Price = 500m,
                            ProductType = 1
                        },
                        new
                        {
                            Id = 4,
                            Datetime = new DateTime(2024, 7, 15, 21, 37, 52, 96, DateTimeKind.Local).AddTicks(4238),
                            Description = "bla bla bla",
                            Name = "samsung s23",
                            Price = 500m,
                            ProductType = 3
                        },
                        new
                        {
                            Id = 5,
                            Datetime = new DateTime(2024, 7, 15, 21, 37, 52, 96, DateTimeKind.Local).AddTicks(4239),
                            Description = "bla bla bla",
                            Name = "samsung note12",
                            Price = 300m,
                            ProductType = 3
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
