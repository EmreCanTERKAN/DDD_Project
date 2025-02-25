using Domain.Products;
using Domain.Shared;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;
internal sealed class ProductRepository(ApplicationDbContext dbContext) : IProductRepository
{
    public async Task CreateAsync(string name, int quantity, decimal amount, string currency, Guid categoryId, CancellationToken cancellationToken = default)
    {
        Product product = new(
            Guid.NewGuid(),
            new(name),
            quantity,
            new(amount, Currency.FromCode(currency)),
            categoryId);
        await dbContext.Products.AddAsync(product, cancellationToken);
        
    }

    public async Task<List<Product>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await dbContext.Products.ToListAsync(cancellationToken);
    }
}
