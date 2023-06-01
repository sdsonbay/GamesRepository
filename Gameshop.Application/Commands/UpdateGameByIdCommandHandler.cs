using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Commands;

public class UpdateGameByIdCommandHandler : IRequestHandler<UpdateGameByIdCommand, UpdateGameByIdOutput>
{
    private readonly IGameService _gameService;

    public UpdateGameByIdCommandHandler(IGameService gameService)
    {
        _gameService = gameService;
    }

    public async Task<UpdateGameByIdOutput> Handle(UpdateGameByIdCommand request, CancellationToken cancellationToken)
    {
        return await _gameService.UpdateGameByIdAsync(request, cancellationToken);
    }
}