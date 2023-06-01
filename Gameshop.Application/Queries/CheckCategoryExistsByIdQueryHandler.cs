using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class CheckCategoryExistsByIdQueryHandler : IRequestHandler<CheckCategoryExistsByIdQuery, CheckCategoryExistsByIdOutput>
{
    private readonly ICategoryService _categoryService;

    public CheckCategoryExistsByIdQueryHandler(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    public async Task<CheckCategoryExistsByIdOutput> Handle(CheckCategoryExistsByIdQuery request, CancellationToken cancellationToken)
    {
        return await _categoryService.CheckCategoryExistsByIdAsync(request, cancellationToken);
    }
}