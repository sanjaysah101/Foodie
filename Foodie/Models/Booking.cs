using System.ComponentModel.DataAnnotations;

namespace Foodie.Models
{
    public class Booking
    {
        [Required]
        public string? Name { get; set; }
        [RegularExpression(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$", ErrorMessage = "Please enter valid email")]
        [Required]
        public string? Email { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public int NoOfPeople { get; set; }
        public string? Message { get; set; }
    }
}
