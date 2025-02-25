using Domain.Orders;
using MediatR;

namespace Application.Features.Orders.GetAllOrder;

internal sealed class GetAllOrderQueryHandler(IOrderRepository orderRepository) : IRequestHandler<GetAllOrderQuery, List<Order>>
{
    public Task<List<Order>> Handle(GetAllOrderQuery request, CancellationToken cancellationToken)
    {
        return orderRepository.GetAllAsync(cancellationToken);
    }
}
