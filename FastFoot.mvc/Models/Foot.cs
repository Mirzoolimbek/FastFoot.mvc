using System.ComponentModel.DataAnnotations;

namespace FastFoot.mvc.Models
{
    public class Foot
    {
        [Key,Required]
        public Guid Id{ get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; }
        public string Image { get; set; } = string.Empty;
    }
}
