using Gameshop.Domain.Args;
using Gameshop.Domain.Ports.Models;
using MediatR;

namespace Gameshop.Application.Commands;

public class UpdateCategoryByIdCommand : UpdateCategoryByIdArgs, IRequest<UpdateCategoryByIdOutput>
{
    
}