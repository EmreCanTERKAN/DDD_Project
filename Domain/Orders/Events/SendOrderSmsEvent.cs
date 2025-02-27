﻿using MediatR;

namespace Domain.Orders.Events;

public sealed class SendOrderSmsEvent : INotificationHandler<OrderDomainEvent>
{
    public Task Handle(OrderDomainEvent notification, CancellationToken cancellationToken)
    {
        //sms sending logic
        return Task.CompletedTask;
    }
}
