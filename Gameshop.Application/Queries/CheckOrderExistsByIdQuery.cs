using Gameshop.Domain.Args;
using Gameshop.Domain.Ports.Models;
using MediatR;

namespace Gameshop.Application.Queries;

public class CheckOrderExistsByIdQuery : CheckOrderExistsByIdArgs, IRequest<CheckOrderExistsByIdOutput>
{
    
}