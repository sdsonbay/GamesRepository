using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetAddressByIdQueryHandler : IRequestHandler<GetAddressByIdQuery, GetAddressByIdOutput>
{
    private readonly IAddressService _addressService;

    public GetAddressByIdQueryHandler(IAddressService addressService)
    {
        _addressService = addressService;
    }

    public async Task<GetAddressByIdOutput> Handle(GetAddressByIdQuery request, CancellationToken cancellationToken)
    {
        return await _addressService.GetAddressByIdAsync(request, cancellationToken);
    }
}