using Gameshop.Domain.Args;
using Gameshop.Domain.Ports.Models;
using MediatR;

namespace Gameshop.Application.Commands;

public class UpdateUserByIdCommand : UpdateUserByIdArgs, IRequest<UpdateUserByIdOutput>
{
    
}