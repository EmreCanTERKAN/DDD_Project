using Domain.Abstractions;
using Domain.Products;
using Domain.Shared;

namespace Domain.Categories;
public sealed class Category : Entity
{
    public Category(Name name, Guid id) : base(id)
    {
        Name = name;
    }

    public Name Name { get; private set; }
    public ICollection<Product> Products { get; private set; } = default!;

    public void ChangeName(string name)
    {
        Name = new Name(name);
    }

}
