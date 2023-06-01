using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Commands;

public class CreateNewUserCommandHandler : IRequestHandler<CreateNewUserCommand, CreateNewUserOutput>
{
    private readonly IUserService _userService;

    public CreateNewUserCommandHandler(IUserService userService)
    {
        _userService = userService;
    }

    public async Task<CreateNewUserOutput> Handle(CreateNewUserCommand request, CancellationToken cancellationToken)
    {
        return await _userService.CreateNewUserAsync(request, cancellationToken);
    }
}