using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetGamesOfCategoryByIdQueryHandler : IRequestHandler<GetGamesOfCategoryByIdQuery, GetGamesOfCategoryByIdOutput>
{
    private readonly ICategoryService _categoryService;

    public GetGamesOfCategoryByIdQueryHandler(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    public async Task<GetGamesOfCategoryByIdOutput> Handle(GetGamesOfCategoryByIdQuery request, CancellationToken cancellationToken)
    {
        return await _categoryService.GetGamesOfCategoryByIdAsync(request, cancellationToken);
    }
}