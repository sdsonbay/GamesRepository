using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetCategoryByNameQueryHandler : IRequestHandler<GetCategoryByNameQuery, GetCategoryByNameOutput>
{
    private readonly ICategoryService _categoryService;

    public GetCategoryByNameQueryHandler(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    public async Task<GetCategoryByNameOutput> Handle(GetCategoryByNameQuery request, CancellationToken cancellationToken)
    {
        return await _categoryService.GetCategoryByNameAsync(request, cancellationToken);
    }
}