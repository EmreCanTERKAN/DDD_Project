using Domain.Abstractions;
using Domain.Categories;
using MediatR;

namespace Application.Features.Categories.CreateCategory;

internal sealed class CreateCategoryCommandHandler(ICategoryRepository categoryRepository , IUnitOfWork unitOfWork) : IRequestHandler<CreateCategoryCommand>
{
    public async Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        await categoryRepository.CreateAsync(request.Name,cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}
