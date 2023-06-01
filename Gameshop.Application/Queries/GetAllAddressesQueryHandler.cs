using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetAllAddressesQueryHandler : IRequestHandler<GetAllAddressesQuery, GetAllAddressesOutput>
{
    private readonly IAddressService _addressService;

    public GetAllAddressesQueryHandler(IAddressService addressService)
    {
        _addressService = addressService;
    }

    public async Task<GetAllAddressesOutput> Handle(GetAllAddressesQuery request, CancellationToken cancellationToken)
    {
        return await _addressService.GetAllAddressesAsync(cancellationToken);
    }
}