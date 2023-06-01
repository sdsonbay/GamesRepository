using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetAddressesOfUserByIdQueryHandler : IRequestHandler<GetAddressesOfUserByIdQuery, GetAddressesOfUserByIdOutput>
{
    private readonly IUserService _userService;

    public GetAddressesOfUserByIdQueryHandler(IUserService userService)
    {
        _userService = userService;
    }

    public async Task<GetAddressesOfUserByIdOutput> Handle(GetAddressesOfUserByIdQuery request, CancellationToken cancellationToken)
    {
        return await _userService.GetAddressesOfUserByIdAsync(request, cancellationToken);
    }
}