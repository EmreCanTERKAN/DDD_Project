using Domain.Users;
using MediatR;

namespace Application.Features.Users.GetAllUser;
public sealed record GetAllUserQuery() : IRequest<List<User>>;
