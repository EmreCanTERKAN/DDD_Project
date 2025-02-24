using Domain.Abstractions;
using Domain.Products;

namespace Domain.Categories;
public sealed class Category : Entity
{
    public Category(Guid id) : base(id)
    {
    }

    public string Name { get; set; } = default!;
    public ICollection<Product> Products { get; set; } = default!;

}
