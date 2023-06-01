using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetGameByNameQueryHandler : IRequestHandler<GetGameByNameQuery, GetGameByNameOutput>
{
    private readonly IGameService _gameService;

    public GetGameByNameQueryHandler(IGameService gameService)
    {
        _gameService = gameService;
    }

    public async Task<GetGameByNameOutput> Handle(GetGameByNameQuery request, CancellationToken cancellationToken)
    {
        return await _gameService.GetGameByNameAsync(request, cancellationToken);
    }
}