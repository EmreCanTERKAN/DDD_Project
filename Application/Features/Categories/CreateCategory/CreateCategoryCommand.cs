using MediatR;

namespace Application.Features.Categories.CreateCategory;
public sealed record CreateCategoryCommand(string Name) : IRequest;
