using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class CheckUserExistsByIdQueryHandler : IRequestHandler<CheckUserExistsByIdQuery, CheckUserExistsByIdOutput>
{
    private readonly IUserService _userService;

    public CheckUserExistsByIdQueryHandler(IUserService userService)
    {
        _userService = userService;
    }

    public async Task<CheckUserExistsByIdOutput> Handle(CheckUserExistsByIdQuery request, CancellationToken cancellationToken)
    {
        return await _userService.CheckUserExistsByIdAsync(request, cancellationToken);
    }
}