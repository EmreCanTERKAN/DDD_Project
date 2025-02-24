using Domain.Abstractions;

namespace Domain.Orders;
public sealed class Order : Entity
{
    public Order(Guid id) : base(id)
    {
    }

    public string OrderNumber { get; set; } = default!;
    public DateTime CreatedDate { get; set; } = default!;
    public OrderStatusEnum Status { get; set; } = default!;
    public ICollection<OrderLine> OrderLines { get; set; } = default!;
}
