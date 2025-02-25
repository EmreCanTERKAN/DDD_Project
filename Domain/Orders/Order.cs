using Domain.Abstractions;
using Domain.Shared;

namespace Domain.Orders;
public sealed class Order : Entity
{
    public Order(Guid id, string orderNumber, DateTime createdDate, OrderStatusEnum status) : base(id)
    {
        OrderNumber = orderNumber;
        CreatedDate = createdDate;
        Status = status;
    }

    public string OrderNumber { get; private set; } = default!;
    public DateTime CreatedDate { get; private set; } = default!;
    public OrderStatusEnum Status { get; private set; } = default!;
    public ICollection<OrderLine> OrderLines { get; private set; } = default!;

    public void CreateOrder(List<CreateOrderDto> createOrderDtos)
    {
        foreach (var item in createOrderDtos)
        {
            #region iş kuralları
            if (item.Quantity < 1)
                throw new ArgumentException("Sipraiş adedi 1den az olamaz!");
            #endregion

            OrderLine orderline = new(
                Guid.NewGuid(),
                Id,
                item.ProductId,
                item.Quantity,
                new(item.Amount, Currency.FromCode(item.Currency)));
            OrderLines.Add(orderline);
        }
    }

    public void RemoveOrderLine(Guid orderLineId)
    {
        var orderLine= OrderLines.FirstOrDefault(p => p.Id == orderLineId);
        if (orderLine is null)
            throw new ArgumentException("silmek istediğin sipariş kalemi bulunamadı.");
        OrderLines.Remove(orderLine);
    }
}
