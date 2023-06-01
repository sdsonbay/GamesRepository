using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Commands;

public class CreateNewGameCommandHandler : IRequestHandler<CreateNewGameCommand, CreateNewGameOutput>
{
    private readonly IGameService _gameService;

    public CreateNewGameCommandHandler(IGameService gameService)
    {
        _gameService = gameService;
    }

    public async Task<CreateNewGameOutput> Handle(CreateNewGameCommand request, CancellationToken cancellationToken)
    {
        return await _gameService.CreateNewGameAsync(request, cancellationToken);
    }
}