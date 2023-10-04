using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VendingProject.Migrations
{
    /// <inheritdoc />
    public partial class AddProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Image", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("073ddaff-2fcb-45df-a90f-b6634c675561"), new DateTime(2023, 10, 4, 10, 7, 32, 780, DateTimeKind.Local).AddTicks(9907), "https://product.hstatic.net/200000438219/product/coca_dc31da7c7a324c9bba5220c27013569f_1024x1024.jpg", "Coca Cola Original", 12, 100 },
                    { new Guid("2cb985ba-546f-4e2e-bfa8-353f23c78dd1"), new DateTime(2023, 10, 4, 10, 7, 32, 780, DateTimeKind.Local).AddTicks(9870), "https://gongcha.com.vn/wp-content/uploads/2022/06/Tra-sua-dolce-tran-chau-HK.png", "Gongcha Milktea", 50, 100 },
                    { new Guid("3ceb87a1-f05d-422b-9dbf-a7c2f293c2ed"), new DateTime(2023, 10, 4, 10, 7, 32, 780, DateTimeKind.Local).AddTicks(9903), "https://cooponline.vn/wp-content/uploads/2021/09/nuoc-giai-khat-pepsi-zero-calo-chanh-320ml-1-20221212.jpg", "Pepsi No Calories", 14, 100 },
                    { new Guid("4083aca8-ba89-4fa9-b548-80185159cd33"), new DateTime(2023, 10, 4, 10, 7, 32, 780, DateTimeKind.Local).AddTicks(9876), "https://bizweb.dktcdn.net/100/433/790/products/bia-heineken-sleek-lon-cao-330ml.jpg?v=1629199193847", "Heineken Beer", 22, 100 },
                    { new Guid("b55e62a6-11b4-4000-b479-a5c6fbaade8f"), new DateTime(2023, 10, 4, 10, 7, 32, 780, DateTimeKind.Local).AddTicks(9900), "https://themewagon.github.io/vegefoods/images/product-8.jpg", "Orange Juice", 22, 100 },
                    { new Guid("c042c3ad-8df3-492d-b992-b843ea4b8f51"), new DateTime(2023, 10, 4, 10, 7, 32, 780, DateTimeKind.Local).AddTicks(9897), "https://themewagon.github.io/vegefoods/images/product-7.jpg", "Carror Orginal", 23, 100 },
                    { new Guid("c9d47b91-f9b8-45d9-bbaf-5eec450f8cf7"), new DateTime(2023, 10, 4, 10, 7, 32, 780, DateTimeKind.Local).AddTicks(9873), "https://www.highlandscoffee.com.vn/vnt_upload/weblink/BrandFresh/Product/PHIN_SUA_DA_5.1.png", "Highland Coffee", 40, 100 },
                    { new Guid("cf7454d3-0813-4a5c-8140-853e0310ebd8"), new DateTime(2023, 10, 4, 10, 7, 32, 780, DateTimeKind.Local).AddTicks(9848), "https://product.hstatic.net/200000078749/product/65_snack_khoai_tay_lay_s_tu_nhien_52g_36b4cfa708634ccda0da9cde011ec9c9_01d2ae27dd8e452e966af95e08e69b11.jpg", "Potato Lays", 12, 100 },
                    { new Guid("d1f52c0c-ef72-48a2-b41f-0a17f38bfd19"), new DateTime(2023, 10, 4, 10, 7, 32, 780, DateTimeKind.Local).AddTicks(9879), "https://themewagon.github.io/vegefoods/images/product-5.jpg", "Orange Juice", 22, 100 },
                    { new Guid("ef07182e-0aa3-4146-a0d9-42a60f0da051"), new DateTime(2023, 10, 4, 10, 7, 32, 780, DateTimeKind.Local).AddTicks(9895), "https://www.nestlemilo.com.vn/sites/default/files/styles/crop_dsu_c_gallery_thumb_large/public/2021-12/hop-giay-uong-lien_Thumb_180ml.png?h=08ae2491&itok=Ey8CKBKo", "Milo 180ml", 12, 100 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
