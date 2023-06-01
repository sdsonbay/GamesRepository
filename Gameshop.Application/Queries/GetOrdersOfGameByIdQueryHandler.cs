using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetOrdersOfGameByIdQueryHandler : IRequestHandler<GetOrdersOfGameByIdQuery, GetOrdersOfGameByIdOutput>
{
    private readonly IGameService _gameService;

    public GetOrdersOfGameByIdQueryHandler(IGameService gameService)
    {
        _gameService = gameService;
    }

    public async Task<GetOrdersOfGameByIdOutput> Handle(GetOrdersOfGameByIdQuery request, CancellationToken cancellationToken)
    {
        return await _gameService.GetOrdersOfGameByIdAsync(request, cancellationToken);
    }
}