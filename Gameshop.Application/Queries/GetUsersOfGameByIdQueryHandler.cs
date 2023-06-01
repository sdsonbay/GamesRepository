using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetUsersOfGameByIdQueryHandler : IRequestHandler<GetUsersOfGameByIdQuery, GetUsersOfGameByIdOutput>
{
    private readonly IGameService _gameService;

    public GetUsersOfGameByIdQueryHandler(IGameService gameService)
    {
        _gameService = gameService;
    }

    public async Task<GetUsersOfGameByIdOutput> Handle(GetUsersOfGameByIdQuery request, CancellationToken cancellationToken)
    {
        return await _gameService.GetUsersOfGameByIdAsync(request, cancellationToken);
    }
}