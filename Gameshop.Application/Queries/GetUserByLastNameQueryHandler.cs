using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetUserByLastNameQueryHandler : IRequestHandler<GetUserByLastNameQuery, GetUsersByLastNameOutput>
{
    private readonly IUserService _userService;

    public GetUserByLastNameQueryHandler(IUserService userService)
    {
        _userService = userService;
    }

    public async Task<GetUsersByLastNameOutput> Handle(GetUserByLastNameQuery request, CancellationToken cancellationToken)
    {
        return await _userService.GetUsersByLastNameAsync(request, cancellationToken);
    }
}