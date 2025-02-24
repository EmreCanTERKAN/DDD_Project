using Domain.Abstractions;

namespace Domain.Orders;
public sealed class Order : Entity
{
    public Order(Guid id, string orderNumber, DateTime createdDate, OrderStatusEnum status, ICollection<OrderLine> orderLines) : base(id)
    {
        OrderNumber = orderNumber;
        CreatedDate = createdDate;
        Status = status;
        OrderLines = orderLines;
    }

    public string OrderNumber { get; private set; } = default!;
    public DateTime CreatedDate { get; private set; } = default!;
    public OrderStatusEnum Status { get; private set; } = default!;
    public ICollection<OrderLine> OrderLines { get; private set; } = default!;
}
