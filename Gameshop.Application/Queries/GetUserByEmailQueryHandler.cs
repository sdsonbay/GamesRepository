using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetUserByEmailQueryHandler : IRequestHandler<GetUserByEmailQuery, GetUserByEmailOutput>
{
    private readonly IUserService _userService;

    public GetUserByEmailQueryHandler(IUserService userService)
    {
        _userService = userService;
    }

    public async Task<GetUserByEmailOutput> Handle(GetUserByEmailQuery request, CancellationToken cancellationToken)
    {
        return await _userService.GetUserByEmailAsync(request, cancellationToken);
    }
}