namespace Domain.Orders;
public sealed class Order
{
    public Guid Id { get; set; }
    public string OrderNumber { get; set; } = default!;
    public DateTime CreatedDate { get; set; } = default!;
    public OrderStatusEnum Status { get; set; } = default!;
    public ICollection<OrderLine> OrderLines { get; set; } = default!;
}
