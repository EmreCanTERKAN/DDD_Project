using Domain.Categories;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;
internal sealed class CategoryRepository(ApplicationDbContext context) : ICategoryRepository
{
    public async Task CreateAsync(string name, CancellationToken cancellationToken = default)
    {
        Category category = new (new(name),Guid.NewGuid());
        await context.Categories.AddAsync(category, cancellationToken);
    }

    public async Task<List<Category>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await context.Categories.ToListAsync(cancellationToken);
    }
}
