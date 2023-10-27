using Entities.Models;

public class Category
{
    public int Id { get; set; }

    public string? CategoryName { get; set; } = String.Empty;

    public ICollection<Product> Products { get; set; }
}