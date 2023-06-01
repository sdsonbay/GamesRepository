using Gameshop.Domain.Args;
using Gameshop.Domain.Ports.Models;
using MediatR;

namespace Gameshop.Application.Commands;

public class DeleteUserByIdCommand : DeleteUserByIdArgs, IRequest<DeleteUserByIdOutput>
{
    
}