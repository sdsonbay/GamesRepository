using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetAllGamesQueryHandler : IRequestHandler<GetAllGamesQuery, GetAllGamesOutput>
{
    private readonly IGameService _gameService;

    public GetAllGamesQueryHandler(IGameService gameService)
    {
        _gameService = gameService;
    }

    public async Task<GetAllGamesOutput> Handle(GetAllGamesQuery request, CancellationToken cancellationToken)
    {
        return await _gameService.GetAllGamesAsync(cancellationToken);
    }
}