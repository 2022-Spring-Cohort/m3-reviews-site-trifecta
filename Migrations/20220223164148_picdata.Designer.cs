﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using template_csharp_reviews_site;

namespace template_csharp_reviews_site.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220223164148_picdata")]
    partial class picdata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("template_csharp_reviews_site.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OSVer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Samsung",
                            Model = "Galaxy",
                            OSVer = "Android 10",
                            Picture = "https://th.bing.com/th/id/OIP.KaKM93VZeh0ZQH0ylnub2gHaHa?pid=ImgDet&rs=1",
                            Price = 800.0,
                            ReleaseDate = new DateTime(2022, 2, 23, 11, 41, 47, 802, DateTimeKind.Local).AddTicks(3410)
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Apple",
                            Model = "iPhone 13 Pro Max",
                            OSVer = "iOS",
                            Picture = "https://th.bing.com/th/id/R.708c4252d828ae9a7f2eb797f7577b30?rik=4b1OYH%2bB6nrH2g&pid=ImgRaw&r=0",
                            Price = 1099.0,
                            ReleaseDate = new DateTime(2022, 2, 23, 11, 41, 47, 810, DateTimeKind.Local).AddTicks(7143)
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Motorola",
                            Model = "Razr",
                            OSVer = "Android 9",
                            Picture = "https://th.bing.com/th/id/OIP.oMxlQYNUc6msuFWHGQOglgHaHc?pid=ImgDet&rs=1",
                            Price = 499.0,
                            ReleaseDate = new DateTime(2022, 2, 23, 11, 41, 47, 810, DateTimeKind.Local).AddTicks(7416)
                        },
                        new
                        {
                            Id = 4,
                            Brand = "GooglePhone",
                            Model = "Pixel 6 Pro",
                            OSVer = "Android 12",
                            Picture = "https://touchit.sk/wp-content/uploads/2021/05/google_pixel_6_6_pro_duo_nowat.jpg",
                            Price = 599.0,
                            ReleaseDate = new DateTime(2022, 2, 23, 11, 41, 47, 810, DateTimeKind.Local).AddTicks(7457)
                        });
                });

            modelBuilder.Entity("template_csharp_reviews_site.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "I love it.",
                            ProductId = 1,
                            Rating = 5,
                            ReviewDate = new DateTime(2022, 2, 23, 11, 41, 47, 810, DateTimeKind.Local).AddTicks(8929),
                            Title = "Great.",
                            UserName = "Lisa"
                        },
                        new
                        {
                            Id = 2,
                            Content = "I love it.",
                            ProductId = 2,
                            Rating = 5,
                            ReviewDate = new DateTime(2022, 2, 23, 11, 41, 47, 811, DateTimeKind.Local).AddTicks(2705),
                            Title = "Great.",
                            UserName = "Norm"
                        },
                        new
                        {
                            Id = 3,
                            Content = "I love it.",
                            ProductId = 3,
                            Rating = 5,
                            ReviewDate = new DateTime(2022, 2, 23, 11, 41, 47, 811, DateTimeKind.Local).AddTicks(2767),
                            Title = "Great.",
                            UserName = "Chaz"
                        },
                        new
                        {
                            Id = 5,
                            Content = "I love it.",
                            ProductId = 1,
                            Rating = 5,
                            ReviewDate = new DateTime(2022, 2, 23, 11, 41, 47, 811, DateTimeKind.Local).AddTicks(2807),
                            Title = "Great.",
                            UserName = "Donna"
                        });
                });

            modelBuilder.Entity("template_csharp_reviews_site.Models.Review", b =>
                {
                    b.HasOne("template_csharp_reviews_site.Models.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("template_csharp_reviews_site.Models.Product", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}