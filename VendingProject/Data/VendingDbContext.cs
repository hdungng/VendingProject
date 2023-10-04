using Microsoft.EntityFrameworkCore;
using VendingProject.Models.Domain;

public class VendingDbContext : DbContext
{
    public VendingDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }


    public DbSet<CartItem> CartItems { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // seed Products
        var products = new List<Product> { 
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Potato Lays",
                Image = "https://product.hstatic.net/200000078749/product/65_snack_khoai_tay_lay_s_tu_nhien_52g_36b4cfa708634ccda0da9cde011ec9c9_01d2ae27dd8e452e966af95e08e69b11.jpg",
                Price = 12,
                Quantity = 100,
                CreatedAt = DateTime.Now,
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Gongcha Milktea",
                Image = "https://gongcha.com.vn/wp-content/uploads/2022/06/Tra-sua-dolce-tran-chau-HK.png",
                Price = 50,
                Quantity = 100,
                CreatedAt = DateTime.Now,
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Highland Coffee",
                Image = "https://www.highlandscoffee.com.vn/vnt_upload/weblink/BrandFresh/Product/PHIN_SUA_DA_5.1.png",
                Price = 40,
                Quantity = 100,
                CreatedAt = DateTime.Now,
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Heineken Beer",
                Image = "https://bizweb.dktcdn.net/100/433/790/products/bia-heineken-sleek-lon-cao-330ml.jpg?v=1629199193847",
                Price = 22,
                Quantity = 100,
                CreatedAt = DateTime.Now,
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Orange Juice",
                Image = "https://themewagon.github.io/vegefoods/images/product-5.jpg",
                Price = 22,
                Quantity = 100,
                CreatedAt = DateTime.Now,
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Milo 180ml",
                Image = "https://www.nestlemilo.com.vn/sites/default/files/styles/crop_dsu_c_gallery_thumb_large/public/2021-12/hop-giay-uong-lien_Thumb_180ml.png?h=08ae2491&itok=Ey8CKBKo",
                Price = 12,
                Quantity = 100,
                CreatedAt = DateTime.Now,
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Carror Orginal",
                Image = "https://themewagon.github.io/vegefoods/images/product-7.jpg",
                Price = 23,
                Quantity = 100,
                CreatedAt = DateTime.Now,
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Orange Juice",
                Image = "https://themewagon.github.io/vegefoods/images/product-8.jpg",
                Price = 22,
                Quantity = 100,
                CreatedAt = DateTime.Now,
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Pepsi No Calories",
                Image = "https://cooponline.vn/wp-content/uploads/2021/09/nuoc-giai-khat-pepsi-zero-calo-chanh-320ml-1-20221212.jpg",
                Price = 14,
                Quantity = 100,
                CreatedAt = DateTime.Now,
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Coca Cola Original",
                Image = "https://product.hstatic.net/200000438219/product/coca_dc31da7c7a324c9bba5220c27013569f_1024x1024.jpg",
                Price = 12,
                Quantity = 100,
                CreatedAt = DateTime.Now,
            },
        };

        modelBuilder.Entity<Product>().HasData(products);
    }
}