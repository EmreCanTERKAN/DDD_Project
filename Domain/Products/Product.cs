using Domain.Categories;

namespace Domain.Products;
public sealed class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public string Currency { get; set; } = default!;
    public Guid CategoryId { get; set; }
    public Category Category { get; set; } = default!;
}
