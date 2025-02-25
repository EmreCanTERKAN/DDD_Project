using Domain.Categories;
using MediatR;

namespace Application.Features.Categories.GetAllCategory;
public sealed record GetAllCategoryQuery() : IRequest<List<Category>>;
