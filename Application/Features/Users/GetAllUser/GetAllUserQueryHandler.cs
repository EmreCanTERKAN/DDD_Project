using Domain.Users;
using MediatR;

namespace Application.Features.Users.GetAllUser;

internal sealed class GetAllUserQueryHandler(IUserRepository userRepository) : IRequestHandler<GetAllUserQuery, List<User>>
{
    public Task<List<User>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
    {
        return userRepository.GetAllAsync(cancellationToken);
    }
}
