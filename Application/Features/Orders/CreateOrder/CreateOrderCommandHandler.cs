using Domain.Abstractions;
using Domain.Orders;
using Domain.Orders.Events;
using MediatR;

namespace Application.Features.Orders.CreateOrder;

internal sealed class CreateOrderCommandHandler(IOrderRepository orderRepository, IUnitOfWork unitOfWork, IMediator mediator) : IRequestHandler<CreateOrderCommand>
{
    public async Task Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        var order = await orderRepository.CreateAsync(request.CreateOrderDtos, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        await mediator.Publish(new OrderDomainEvent(order));
    }
}
