using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetUserOfCreditCardByIdQueryHandler : IRequestHandler<GetUserOfCreditCardByIdQuery, GetUserOfCreditCardByIdOutput>
{
    private readonly ICreditCardService _creditCardService;

    public GetUserOfCreditCardByIdQueryHandler(ICreditCardService creditCardService)
    {
        _creditCardService = creditCardService;
    }

    public async Task<GetUserOfCreditCardByIdOutput> Handle(GetUserOfCreditCardByIdQuery request, CancellationToken cancellationToken)
    {
        return await _creditCardService.GetUserOfCreditCardByIdAsync(request, cancellationToken);
    }
}