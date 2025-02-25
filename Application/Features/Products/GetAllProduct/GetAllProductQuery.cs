using Domain.Products;
using MediatR;

namespace Application.Features.Products.GetAllProduct;
public sealed record GetAllProductQuery() : IRequest<List<Product>>;

