using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Commands;

public class DeleteGameByIdCommandHandler : IRequestHandler<DeleteGameByIdCommand, DeleteGameByIdOutput>
{
    private readonly IGameService _gameService;

    public DeleteGameByIdCommandHandler(IGameService gameService)
    {
        _gameService = gameService;
    }

    public async Task<DeleteGameByIdOutput> Handle(DeleteGameByIdCommand request, CancellationToken cancellationToken)
    {
        return await _gameService.DeleteGameByIdAsync(request, cancellationToken);
    }
}