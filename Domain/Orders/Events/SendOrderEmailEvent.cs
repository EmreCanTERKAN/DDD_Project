using MediatR;

namespace Domain.Orders.Events;
public sealed class SendOrderEmailEvent : INotificationHandler<OrderDomainEvent>
{
    public Task Handle(OrderDomainEvent notification, CancellationToken cancellationToken)
    {
        //mail sending logic
        return Task.CompletedTask;
    }
}
