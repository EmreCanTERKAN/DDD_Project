using Domain.Orders;
using MediatR;

namespace Application.Features.Orders.GetAllOrder;
public sealed record GetAllOrderQuery() : IRequest<List<Order>>;
