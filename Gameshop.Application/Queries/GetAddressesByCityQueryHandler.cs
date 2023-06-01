using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetAddressesByCityQueryHandler : IRequestHandler<GetAddressesByCityQuery, GetAddressesByCityOutput>
{
    private readonly IAddressService _addressService;

    public GetAddressesByCityQueryHandler(IAddressService addressService)
    {
        _addressService = addressService;
    }

    public async Task<GetAddressesByCityOutput> Handle(GetAddressesByCityQuery request, CancellationToken cancellationToken)
    {
        return await _addressService.GetAddressesByCityAsync(request, cancellationToken);
    }
}