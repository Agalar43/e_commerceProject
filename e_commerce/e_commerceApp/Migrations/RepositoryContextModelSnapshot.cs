﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories;

#nullable disable

namespace ecommerceApp.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("Entities.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Elektronik"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Book"
                        });
                });

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductRanking")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Stock")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("unitPrice")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            CategoryID = 1,
                            ImageUrl = "null",
                            ProductDescription = "son model işlemciye sahip",
                            ProductName = "Bilgisayar",
                            ProductRanking = "0",
                            Stock = 10,
                            unitPrice = 1000m
                        },
                        new
                        {
                            ProductID = 2,
                            CategoryID = 1,
                            ImageUrl = "null",
                            ProductDescription = "son model işlemciye sahip",
                            ProductName = "Telefon",
                            ProductRanking = "0",
                            Stock = 10,
                            unitPrice = 1000m
                        });
                });

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.HasOne("Entities.Models.Category", "category")
                        .WithMany("products")
                        .HasForeignKey("CategoryID");

                    b.Navigation("category");
                });

            modelBuilder.Entity("Entities.Models.Category", b =>
                {
                    b.Navigation("products");
                });
#pragma warning restore 612, 618
        }
    }
}
