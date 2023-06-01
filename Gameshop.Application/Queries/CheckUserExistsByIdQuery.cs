using Gameshop.Domain.Args;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using MediatR;

namespace Gameshop.Application.Queries;

public class CheckUserExistsByIdQuery : CheckUserExistsByIdArgs, IRequest<CheckUserExistsByIdOutput>
{
    
}