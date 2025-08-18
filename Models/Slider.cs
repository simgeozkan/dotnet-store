namespace dotnet_store.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } = null!;
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public int Index { get; set; }
    }
}
