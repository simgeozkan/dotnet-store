namespace dotnet_store.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!; // buraya bir deger gonderecegim
        public string? Description { get; set; }
        public string? Url { get; set; }
        public bool IsActive { get; set; }

    public List<Product> Products { get; set; } = new(); // urun tablosu ile baglanti kurduk
    }
}

