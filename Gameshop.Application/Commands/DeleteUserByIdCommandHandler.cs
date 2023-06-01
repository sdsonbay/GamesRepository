using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Commands;

public class DeleteUserByIdCommandHandler : IRequestHandler<DeleteUserByIdCommand, DeleteUserByIdOutput>
{
    private readonly IUserService _userService;

    public DeleteUserByIdCommandHandler(IUserService userService)
    {
        _userService = userService;
    }

    public async Task<DeleteUserByIdOutput> Handle(DeleteUserByIdCommand request, CancellationToken cancellationToken)
    {
        return await _userService.DeleteUserByIdAsync(request, cancellationToken);
    }
}