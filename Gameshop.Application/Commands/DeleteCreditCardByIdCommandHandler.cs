using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Commands;

public class DeleteCreditCardByIdCommandHandler : IRequestHandler<DeleteCreditCardByIdCommand, DeleteCreditCardByIdOutput>
{
    private readonly ICreditCardService _creditCardService;

    public DeleteCreditCardByIdCommandHandler(ICreditCardService creditCardService)
    {
        _creditCardService = creditCardService;
    }

    public async Task<DeleteCreditCardByIdOutput> Handle(DeleteCreditCardByIdCommand request, CancellationToken cancellationToken)
    {
        return await _creditCardService.DeleteCreditCardByIdAsync(request, cancellationToken);
    }
}