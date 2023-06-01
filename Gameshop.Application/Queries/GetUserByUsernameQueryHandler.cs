using AutoMapper;
using Gameshop.Domain.Args;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetUserByUsernameQueryHandler : IRequestHandler<GetUserByUsernameQuery, GetUserByUsernameOutput>
{
    private readonly IUserService _userService;

    public GetUserByUsernameQueryHandler(IUserService userService)
    {
        _userService = userService;
    }

    public async Task<GetUserByUsernameOutput> Handle(GetUserByUsernameQuery request, CancellationToken cancellationToken)
    {
        return await _userService.GetUserByUsernameAsync(request, cancellationToken);
    }
}