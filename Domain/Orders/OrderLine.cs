﻿using Domain.Abstractions;
using Domain.Products;
using Domain.Shared;

namespace Domain.Orders;

public sealed class OrderLine : Entity
{
    public OrderLine(Guid id,Guid orderId, Guid productId, int quantity, Money price) : base(id)
    {
        ProductId = productId;
        Quantity = quantity;
        Price = price;
    }

    public Guid OrderId { get; private set; }
    public Guid ProductId { get; private set; }
    public Product Product { get; private set; } = default!;
    public int Quantity { get; private set; }
    public Money Price { get; private set; }
}
