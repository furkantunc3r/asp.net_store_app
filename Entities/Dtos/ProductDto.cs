using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record ProductDto
    {
        public int ProductId { get; init; }

        [Required(ErrorMessage = "ProduinitctName is required.")]
        public string? ProductName { get; init; }

        [Required(ErrorMessage = "Price is required.")]
        public decimal Price { get; init; }

        public String? Summary { get; init; } = String.Empty;

        public String? ImageUrl { get; set; }

        public int? CategoryId { get; set; }

        public Category? Category { get; init; }
    }
}