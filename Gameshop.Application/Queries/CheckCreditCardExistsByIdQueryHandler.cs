using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class CheckCreditCardExistsByIdQueryHandler : IRequestHandler<CheckCreditCardExistsByIdQuery, CheckCreditCardExistsByIdOutput>
{
    private readonly ICreditCardService _creditCardService;

    public CheckCreditCardExistsByIdQueryHandler(ICreditCardService creditCardService)
    {
        _creditCardService = creditCardService;
    }

    public async Task<CheckCreditCardExistsByIdOutput> Handle(CheckCreditCardExistsByIdQuery request, CancellationToken cancellationToken)
    {
        return await _creditCardService.CheckCreditCardExistsByIdAsync(request, cancellationToken);
    }
}