using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Commands;

public class CreateNewCategoryCommandHandler : IRequestHandler<CreateNewCategoryCommand, CreateNewCategoryOutput>
{
    private readonly ICategoryService _categoryService;

    public CreateNewCategoryCommandHandler(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    public async Task<CreateNewCategoryOutput> Handle(CreateNewCategoryCommand request, CancellationToken cancellationToken)
    {
        return await _categoryService.CreateNewCategoryAsync(request, cancellationToken);
    }
}