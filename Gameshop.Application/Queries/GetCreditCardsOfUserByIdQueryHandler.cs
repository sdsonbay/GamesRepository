using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetCreditCardsOfUserByIdQueryHandler : IRequestHandler<GetCreditCardsOfUserByIdQuery, GetCreditCardsOfUserByIdOutput>
{
    private readonly IUserService _userService;

    public GetCreditCardsOfUserByIdQueryHandler(IUserService userService)
    {
        _userService = userService;
    }

    public async Task<GetCreditCardsOfUserByIdOutput> Handle(GetCreditCardsOfUserByIdQuery request, CancellationToken cancellationToken)
    {
        return await _userService.GetCreditCardsOfUserByIdAsync(request, cancellationToken);
    }
}