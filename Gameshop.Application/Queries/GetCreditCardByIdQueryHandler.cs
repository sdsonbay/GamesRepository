using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetCreditCardByIdQueryHandler : IRequestHandler<GetCreditCardByIdQuery, GetCreditCardByIdOutput>
{
    private readonly ICreditCardService _creditCardService;

    public GetCreditCardByIdQueryHandler(ICreditCardService creditCardService)
    {
        _creditCardService = creditCardService;
    }

    public async Task<GetCreditCardByIdOutput> Handle(GetCreditCardByIdQuery request, CancellationToken cancellationToken)
    {
        return await _creditCardService.GetCreditCardByIdAsync(request, cancellationToken);
    }
}