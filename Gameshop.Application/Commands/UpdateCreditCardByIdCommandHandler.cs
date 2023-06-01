using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Commands;

public class UpdateCreditCardByIdCommandHandler : IRequestHandler<UpdateCreditCardByIdCommand, UpdateCreditCardByIdOutput>
{
    private readonly ICreditCardService _creditCardService;

    public UpdateCreditCardByIdCommandHandler(ICreditCardService creditCardService)
    {
        _creditCardService = creditCardService;
    }

    public async Task<UpdateCreditCardByIdOutput> Handle(UpdateCreditCardByIdCommand request, CancellationToken cancellationToken)
    {
        return await _creditCardService.UpdateCreditCardByIdAsync(request, cancellationToken);
    }
}