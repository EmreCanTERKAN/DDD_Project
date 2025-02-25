using Domain.Abstractions;
using Domain.Products;
using MediatR;

namespace Application.Features.Products.CreateProduct;

internal sealed class CreateProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork) : IRequestHandler<CreateProductCommand>
{
    public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        await productRepository.CreateAsync(
            request.Name,
            request.Quantity,
            request.Amount,
            request.Currency, 
            request.CategoryId,
            cancellationToken);

        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}
