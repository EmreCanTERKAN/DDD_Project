using Domain.Products;
using MediatR;

namespace Application.Features.Products.GetAllProduct;

internal sealed class GetAllProductQueryHandler(IProductRepository productRepository) : IRequestHandler<GetAllProductQuery, List<Product>>
{
    public async Task<List<Product>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
    {
        return await productRepository.GetAllAsync(cancellationToken);
    }
}

