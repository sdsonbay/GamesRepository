using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetGameByIdQueryHandler : IRequestHandler<GetGameByIdQuery, GetGameByIdOutput>
{
    private readonly IGameService _gameService;

    public GetGameByIdQueryHandler(IGameService gameService)
    {
        _gameService = gameService;
    }

    public async Task<GetGameByIdOutput> Handle(GetGameByIdQuery request, CancellationToken cancellationToken)
    {
        return await _gameService.GetGameByIdAsync(request, cancellationToken);
    }
}