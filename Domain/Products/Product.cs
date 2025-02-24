﻿using Domain.Abstractions;
using Domain.Categories;
using Domain.Shared;

namespace Domain.Products;
public sealed class Product : Entity
{
    public Product(Guid id, Name name, int quantity, Money? price, Guid categoryId, Category category) : base(id)
    {
        Name = name;
        Quantity = quantity;
        Price = price;
        CategoryId = categoryId;
        Category = category;
    }

    public Name Name { get; private set; } = default!;
    public int Quantity { get; private set; }
    public Money? Price { get; private set; }
    public Guid CategoryId { get; private set; }
    public Category Category { get; private set; } = default!;

    public void Update(string name,int quantity,decimal amount, string currency, Guid categoryId)
    {
        Name = new(name);
        Quantity = quantity;
        Price = new(amount, Currency.FromCode(currency));
        CategoryId = categoryId;
    }
}
