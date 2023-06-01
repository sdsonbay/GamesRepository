using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetOrdersOfUserByIdQueryHandler : IRequestHandler<GetOrdersOfUserByIdQuery, GetOrdersOfUserByIdOutput>
{
    private readonly IUserService _userService;

    public GetOrdersOfUserByIdQueryHandler(IUserService userService)
    {
        _userService = userService;
    }

    public async Task<GetOrdersOfUserByIdOutput> Handle(GetOrdersOfUserByIdQuery request, CancellationToken cancellationToken)
    {
        return await _userService.GetOrdersOfUserByIdAsync(request, cancellationToken);
    }
}