using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, GetAllUsersOutput>
{
    private readonly IUserService _userService;

    public GetAllUsersQueryHandler(IUserService userService)
    {
        _userService = userService;
    }
    
    public async Task<GetAllUsersOutput> Handle(GetAllUsersQuery request, CancellationToken cancellationToken = default)
    {
        return await _userService.GetAllUsersAsync(cancellationToken);
    }
}