using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Commands;

public class UpdateCategoryByIdCommandHandler : IRequestHandler<UpdateCategoryByIdCommand, UpdateCategoryByIdOutput>
{
    private readonly ICategoryService _categoryService;

    public UpdateCategoryByIdCommandHandler(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    public async Task<UpdateCategoryByIdOutput> Handle(UpdateCategoryByIdCommand request, CancellationToken cancellationToken)
    {
        return await _categoryService.UpdateCategoryByIdAsync(request, cancellationToken);
    }
}