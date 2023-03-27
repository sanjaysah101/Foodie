namespace Foodie.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Images { get; set; }
        public string? Tags { get; set; }
        //public GetUserDto User { get; set; }
        public int UserId { get; set; }
        public List<Items> Items { get; set; }
    }
}
