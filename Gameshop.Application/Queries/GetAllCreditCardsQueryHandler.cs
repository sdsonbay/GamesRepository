using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetAllCreditCardsQueryHandler : IRequestHandler<GetAllCreditCardsQuery, GetAllCreditCardsOutput>
{
    private readonly ICreditCardService _creditCardService;

    public GetAllCreditCardsQueryHandler(ICreditCardService creditCardService)
    {
        _creditCardService = creditCardService;
    }

    public async Task<GetAllCreditCardsOutput> Handle(GetAllCreditCardsQuery request, CancellationToken cancellationToken)
    {
        return await _creditCardService.GetAllCreditCardsAsync(cancellationToken);
    }
}