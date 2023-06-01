using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Commands;

public class UpdateUserByIdCommandHandler : IRequestHandler<UpdateUserByIdCommand, UpdateUserByIdOutput>
{
    private readonly IUserService _userService;

    public UpdateUserByIdCommandHandler(IUserService userService)
    {
        _userService = userService;
    }

    public async Task<UpdateUserByIdOutput> Handle(UpdateUserByIdCommand request, CancellationToken cancellationToken)
    {
        return await _userService.UpdateUserByIdAsync(request, cancellationToken);
    }
}