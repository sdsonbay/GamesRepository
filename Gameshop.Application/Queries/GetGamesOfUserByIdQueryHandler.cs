using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetGamesOfUserByIdQueryHandler : IRequestHandler<GetGamesOfUserByIdQuery, GetGamesOfUserByIdOutput>
{
    private readonly IUserService _userService;

    public GetGamesOfUserByIdQueryHandler(IUserService userService)
    {
        _userService = userService;
    }

    public async Task<GetGamesOfUserByIdOutput> Handle(GetGamesOfUserByIdQuery request, CancellationToken cancellationToken)
    {
        return await _userService.GetGamesOfUserByIdAsync(request, cancellationToken);
    }
}