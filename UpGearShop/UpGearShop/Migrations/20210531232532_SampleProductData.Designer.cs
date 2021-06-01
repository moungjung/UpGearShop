﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UpGearShop.Data;

namespace UpGearShop.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210531232532_SampleProductData")]
    partial class SampleProductData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UpGearShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("UpGearShop.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Coco",
                            Price = 23m
                        },
                        new
                        {
                            Id = 2,
                            Name = "Hunger",
                            Price = 23m
                        },
                        new
                        {
                            Id = 3,
                            Name = "Yeezys",
                            Price = 12.99m
                        },
                        new
                        {
                            Id = 4,
                            Name = "Hunger",
                            Price = 23m
                        },
                        new
                        {
                            Id = 5,
                            Name = "CCIV",
                            Price = 43.99m
                        },
                        new
                        {
                            Id = 6,
                            Name = "Hunger",
                            Price = 23m
                        },
                        new
                        {
                            Id = 7,
                            Name = "Hunger",
                            Price = 23m
                        },
                        new
                        {
                            Id = 8,
                            Name = "Jordans",
                            Price = 13.99m
                        });
                });

            modelBuilder.Entity("UpGearShop.Models.Product", b =>
                {
                    b.HasOne("UpGearShop.Models.Category", null)
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("UpGearShop.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}