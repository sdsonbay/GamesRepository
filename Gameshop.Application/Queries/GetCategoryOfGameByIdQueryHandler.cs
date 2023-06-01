using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetCategoryOfGameByIdQueryHandler : IRequestHandler<GetCategoryOfGameByIdQuery, GetCategoryOfGameByIdOutput>
{
    private readonly IGameService _gameService;

    public GetCategoryOfGameByIdQueryHandler(IGameService gameService)
    {
        _gameService = gameService;
    }

    public async Task<GetCategoryOfGameByIdOutput> Handle(GetCategoryOfGameByIdQuery request, CancellationToken cancellationToken)
    {
        return await _gameService.GetCategoryOfGameByIdAsync(request, cancellationToken);
    }
}