using Gameshop.Domain.Args;
using Gameshop.Domain.Ports.Models;
using MediatR;

namespace Gameshop.Application.Commands;

public class DeleteCreditCardByIdCommand : DeleteCreditCardByIdArgs, IRequest<DeleteCreditCardByIdOutput>
{
    
}