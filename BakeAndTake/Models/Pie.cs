using System.ComponentModel.DataAnnotations.Schema;

namespace BakeAndTake.Models
{
    public class Pie
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string ShortDescription { get; set; } = null!;
        public string? LongDescription { get; set; }
        public string AllergyInformation { get; set; } = null!;
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = null!;
        public string ImageThumbnail { get; set; } = null!;
        public bool IsPieOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public string? Notes { get; set; }
    }
}
