using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetUserByFirstNameQueryHandler : IRequestHandler<GetUserByFirstNameQuery, GetUsersByFirstNameOutput>
{
    private readonly IUserService _userService;

    public GetUserByFirstNameQueryHandler(IUserService userService)
    {
        _userService = userService;
    }

    public async Task<GetUsersByFirstNameOutput> Handle(GetUserByFirstNameQuery request, CancellationToken cancellationToken)
    {
        return await _userService.GetUsersByFirstNameAsync(request, cancellationToken);
    }
}