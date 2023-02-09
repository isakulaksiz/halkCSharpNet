using System.ComponentModel.DataAnnotations;

namespace eshop.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen ad alanını giriniz")]
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public double? DiscountRate { get; set; }
        public string? ImageUrl { get; set; }

        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}
