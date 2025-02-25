using Domain.Orders;
using MediatR;

namespace Application.Features.Orders.CreateOrder;
public sealed record CreateOrderCommand(List<CreateOrderDto> CreateOrderDtos) : IRequest;
