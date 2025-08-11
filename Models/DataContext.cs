namespace dotnet_store.Models;

using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{

        // yapici metot;nesne olusturma asamasinda otomatik olarak cagrilir
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }


    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) // migration olusturdugunda bu metot cagirirlir
    {
        base.OnModelCreating(modelBuilder);
       




        modelBuilder.Entity<Product>().HasData(

        new List<Product>{

            new Product(){ Id=1, Name="apple1",Price=5000,IsActive=true},
            new Product(){ Id=2, Name="apple2",Price=3000,IsActive=true},
            new Product(){ Id=3, Name="apple3",Price=2000,IsActive=true},
            new Product(){ Id=4, Name="apple4",Price=4000,IsActive=true},
            new Product(){ Id=5, Name="apple5",Price=17000,IsActive=true}

        }

            
        );
    }
}
