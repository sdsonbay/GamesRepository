using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetPublisherOfGameByIdQueryHandler : IRequestHandler<GetPublisherOfGameByIdQuery, GetPublisherOfGameByIdOutput>
{
    private readonly IGameService _gameService;

    public GetPublisherOfGameByIdQueryHandler(IGameService gameService)
    {
        _gameService = gameService;
    }

    public async Task<GetPublisherOfGameByIdOutput> Handle(GetPublisherOfGameByIdQuery request, CancellationToken cancellationToken)
    {
        return await _gameService.GetPublisherOfGameByIdAsync(request, cancellationToken);
    }
}