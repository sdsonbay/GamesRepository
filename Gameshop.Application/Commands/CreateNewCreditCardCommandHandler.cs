using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Commands;

public class CreateNewCreditCardCommandHandler : IRequestHandler<CreateNewCreditCardCommand, CreateNewCreditCardOutput>
{
    private readonly ICreditCardService _creditCardService;

    public CreateNewCreditCardCommandHandler(ICreditCardService creditCardService)
    {
        _creditCardService = creditCardService;
    }

    public async Task<CreateNewCreditCardOutput> Handle(CreateNewCreditCardCommand request, CancellationToken cancellationToken)
    {
        return await _creditCardService.CreateNewCreditCardAsync(request, cancellationToken);
    }
}