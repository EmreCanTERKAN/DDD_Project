using Domain.Abstractions;
using Domain.Users;
using Domain.Users.Events;
using MediatR;

namespace Application.Features.Users.CreateUser;

internal sealed class CreateUserCommandHandler(IUserRepository userRepository,IUnitOfWork unitOfWork, IMediator mediator) : IRequestHandler<CreateUserCommand>
{
    public async Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        //iş kuralları
       var user = await userRepository.CreateAsync(
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
        await mediator.Publish(new UserDomainEvent(user));
    }
}
