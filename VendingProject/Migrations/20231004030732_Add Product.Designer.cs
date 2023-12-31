﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace VendingProject.Migrations
{
    [DbContext(typeof(VendingDbContext))]
    [Migration("20231004030732_Add Product")]
    partial class AddProduct
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VendingProject.Models.Domain.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cf7454d3-0813-4a5c-8140-853e0310ebd8"),
                            CreatedAt = new DateTime(2023, 10, 4, 10, 7, 32, 780, DateTimeKind.Local).AddTicks(9848),
                            Image = "https://product.hstatic.net/200000078749/product/65_snack_khoai_tay_lay_s_tu_nhien_52g_36b4cfa708634ccda0da9cde011ec9c9_01d2ae27dd8e452e966af95e08e69b11.jpg",
                            Name = "Potato Lays",
                            Price = 12,
                            Quantity = 100
                        },
                        new
                        {
                            Id = new Guid("2cb985ba-546f-4e2e-bfa8-353f23c78dd1"),
                            CreatedAt = new DateTime(2023, 10, 4, 10, 7, 32, 780, DateTimeKind.Local).AddTicks(9870),
                            Image = "https://gongcha.com.vn/wp-content/uploads/2022/06/Tra-sua-dolce-tran-chau-HK.png",
                            Name = "Gongcha Milktea",
                            Price = 50,
                            Quantity = 100
                        },
                        new
                        {
                            Id = new Guid("c9d47b91-f9b8-45d9-bbaf-5eec450f8cf7"),
                            CreatedAt = new DateTime(2023, 10, 4, 10, 7, 32, 780, DateTimeKind.Local).AddTicks(9873),
                            Image = "https://www.highlandscoffee.com.vn/vnt_upload/weblink/BrandFresh/Product/PHIN_SUA_DA_5.1.png",
                            Name = "Highland Coffee",
                            Price = 40,
                            Quantity = 100
                        },
                        new
                        {
                            Id = new Guid("4083aca8-ba89-4fa9-b548-80185159cd33"),
                            CreatedAt = new DateTime(2023, 10, 4, 10, 7, 32, 780, DateTimeKind.Local).AddTicks(9876),
                            Image = "https://bizweb.dktcdn.net/100/433/790/products/bia-heineken-sleek-lon-cao-330ml.jpg?v=1629199193847",
                            Name = "Heineken Beer",
                            Price = 22,
                            Quantity = 100
                        },
                        new
                        {
                            Id = new Guid("d1f52c0c-ef72-48a2-b41f-0a17f38bfd19"),
                            CreatedAt = new DateTime(2023, 10, 4, 10, 7, 32, 780, DateTimeKind.Local).AddTicks(9879),
                            Image = "https://themewagon.github.io/vegefoods/images/product-5.jpg",
                            Name = "Orange Juice",
                            Price = 22,
                            Quantity = 100
                        },
                        new
                        {
                            Id = new Guid("ef07182e-0aa3-4146-a0d9-42a60f0da051"),
                            CreatedAt = new DateTime(2023, 10, 4, 10, 7, 32, 780, DateTimeKind.Local).AddTicks(9895),
                            Image = "https://www.nestlemilo.com.vn/sites/default/files/styles/crop_dsu_c_gallery_thumb_large/public/2021-12/hop-giay-uong-lien_Thumb_180ml.png?h=08ae2491&itok=Ey8CKBKo",
                            Name = "Milo 180ml",
                            Price = 12,
                            Quantity = 100
                        },
                        new
                        {
                            Id = new Guid("c042c3ad-8df3-492d-b992-b843ea4b8f51"),
                            CreatedAt = new DateTime(2023, 10, 4, 10, 7, 32, 780, DateTimeKind.Local).AddTicks(9897),
                            Image = "https://themewagon.github.io/vegefoods/images/product-7.jpg",
                            Name = "Carror Orginal",
                            Price = 23,
                            Quantity = 100
                        },
                        new
                        {
                            Id = new Guid("b55e62a6-11b4-4000-b479-a5c6fbaade8f"),
                            CreatedAt = new DateTime(2023, 10, 4, 10, 7, 32, 780, DateTimeKind.Local).AddTicks(9900),
                            Image = "https://themewagon.github.io/vegefoods/images/product-8.jpg",
                            Name = "Orange Juice",
                            Price = 22,
                            Quantity = 100
                        },
                        new
                        {
                            Id = new Guid("3ceb87a1-f05d-422b-9dbf-a7c2f293c2ed"),
                            CreatedAt = new DateTime(2023, 10, 4, 10, 7, 32, 780, DateTimeKind.Local).AddTicks(9903),
                            Image = "https://cooponline.vn/wp-content/uploads/2021/09/nuoc-giai-khat-pepsi-zero-calo-chanh-320ml-1-20221212.jpg",
                            Name = "Pepsi No Calories",
                            Price = 14,
                            Quantity = 100
                        },
                        new
                        {
                            Id = new Guid("073ddaff-2fcb-45df-a90f-b6634c675561"),
                            CreatedAt = new DateTime(2023, 10, 4, 10, 7, 32, 780, DateTimeKind.Local).AddTicks(9907),
                            Image = "https://product.hstatic.net/200000438219/product/coca_dc31da7c7a324c9bba5220c27013569f_1024x1024.jpg",
                            Name = "Coca Cola Original",
                            Price = 12,
                            Quantity = 100
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
