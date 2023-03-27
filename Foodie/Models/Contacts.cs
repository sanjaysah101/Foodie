using System.ComponentModel.DataAnnotations;

namespace Foodie.Models
{
    public class Contacts
    {
        [Required(ErrorMessage = "Please enter name")]
        public string? Name { get; set; }
        [Required]
        [RegularExpression(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$", ErrorMessage = " Please enter valid email")]
        public string? Email { get; set; }
        [Required]
        public string? Subject { get; set; }
        [Required]
        public string? Message { get; set; }
    }
}
