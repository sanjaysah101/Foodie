namespace Foodie.Models
{
    public class Items
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Images { get; set; } = string.Empty;
        public int Price { get; set; }
    }
}
