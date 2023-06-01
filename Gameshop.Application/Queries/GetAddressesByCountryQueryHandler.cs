using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetAddressesByCountryQueryHandler : IRequestHandler<GetAddressesByCountryQuery, GetAddressesByCountryOutput>
{
    private readonly IAddressService _addressService;

    public GetAddressesByCountryQueryHandler(IAddressService addressService)
    {
        _addressService = addressService;
    }

    public async Task<GetAddressesByCountryOutput> Handle(GetAddressesByCountryQuery request, CancellationToken cancellationToken)
    {
        return await _addressService.GetAddressesByCountryAsync(request, cancellationToken);
    }
}