using Domain.Abstractions;
using Domain.Users;
using MediatR;

namespace Application.Features.Users.CreateUser;

internal sealed class CreateUserCommandHandler(IUserRepository userRepository,IUnitOfWork unitOfWork) : IRequestHandler<CreateUserCommand>
{
    public async Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        //iş kuralları
        await userRepository.CreateAsync(
            request.Name,
            request.Email,
            request.Password,
            request.Country,
            request.City,
            request.Street,
            request.PostalCode,
            request.FullAddress,
            cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}
