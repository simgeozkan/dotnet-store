namespace dotnet_store.Models;

using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{

        // yapici metot;nesne olusturma asamasinda otomatik olarak cagrilir
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }


    public DbSet<Product> Products { get; set; }  // product sinifina denk gelir

   public DbSet<Category> Categories { get; set; } // category sinifina denk gelir

    public DbSet<Slider> Sliders { get; set; } 

    protected override void OnModelCreating(ModelBuilder modelBuilder) // migration olusturdugunda bu metot cagirirlir
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Slider>().HasData(
            new List<Slider>
            {
                new Slider { Id = 1, ImageUrl = "slider-1.jpeg", Title = "Slider 1", Description = "Slider 1 açıklaması", IsActive = true, Index = 0 },
                new Slider { Id = 2, ImageUrl = "slider-2.jpeg", Title = "Slider 2", Description = "Slider 2 açıklaması", IsActive = true, Index = 1 },
                new Slider { Id = 3, ImageUrl = "slider-3.jpeg", Title = "Slider 3", Description = "Slider 3 açıklaması", IsActive = true, Index = 2 }
            }
        );
       

        modelBuilder.Entity<Category>().HasData(
            new List<Category>
            {
                new Category { Id = 1, Name = "Elektronik", Description = "Elektronik ürünler", Url = "elektronik", IsActive = true },
                new Category { Id = 2, Name = "Giyim", Description = "Giyim ürünleri", Url = "giyim", IsActive = true },
                new Category { Id = 3, Name = "Ev & Yaşam", Description = "Ev ve yaşam ürünleri", Url = "ev-yasam", IsActive = true }

                ,
                new Category { Id = 4, Name = "Spor & Outdoor", Description = "Spor ve outdoor ürünleri", Url = "spor-outdoor", IsActive = true },
                new Category { Id = 5, Name = "Kitap & Kırtasiye", Description = "Kitap ve kırtasiye ürünleri", Url = "kitap-kirtasiye", IsActive = true },
                new Category { Id = 6, Name = "Kozmetik & Kişisel Bakım", Description = "Kozmetik ve kişisel bakım ürünleri", Url = "kozmetik-kisisel-bakim", IsActive = true }
            }
        );



        modelBuilder.Entity<Product>().HasData(

        new List<Product>{

            new Product(){ Id=1, Name="apple1",Price=5000,IsActive=true,Image="1.jpeg",HomePage=true,Description="lorem ipsum",CategoryId=1},
            new Product(){ Id=2, Name="apple2",Price=3000,IsActive=true,Image="2.jpeg",HomePage=false,Description="lorem ipsum",CategoryId=2},
            new Product(){ Id=3, Name="apple3",Price=2000,IsActive=true,Image="3.jpeg",HomePage=true,Description="lorem ipsum",CategoryId=3},
            new Product(){ Id=4, Name="apple4",Price=4000,IsActive=true,Image="4.jpeg",HomePage=true,Description="lorem ipsum",CategoryId=1},
            new Product(){ Id=5, Name="apple5",Price=17000,IsActive=true,Image="5.jpeg",HomePage=false,Description="lorem ipsum",CategoryId=2}

        }

            
        );
    }
}
