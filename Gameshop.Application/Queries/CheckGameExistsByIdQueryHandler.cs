using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class CheckGameExistsByIdQueryHandler : IRequestHandler<CheckGameExistsByIdQuery, CheckGameExistsByIdOutput>
{
    private readonly IGameService _gameService;

    public CheckGameExistsByIdQueryHandler(IGameService gameService)
    {
        _gameService = gameService;
    }

    public async Task<CheckGameExistsByIdOutput> Handle(CheckGameExistsByIdQuery request, CancellationToken cancellationToken)
    {
        return await _gameService.CheckGameExistsByIdAsync(request, cancellationToken);
    }
}