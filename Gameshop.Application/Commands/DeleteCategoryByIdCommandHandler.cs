using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Commands;

public class DeleteCategoryByIdCommandHandler : IRequestHandler<DeleteCategoryByIdCommand, DeleteCategoryByIdOutput>
{
    private readonly ICategoryService _categoryService;

    public DeleteCategoryByIdCommandHandler(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    public async Task<DeleteCategoryByIdOutput> Handle(DeleteCategoryByIdCommand request, CancellationToken cancellationToken)
    {
        return await _categoryService.DeleteCategoryByIdAsync(request, cancellationToken);
    }
}