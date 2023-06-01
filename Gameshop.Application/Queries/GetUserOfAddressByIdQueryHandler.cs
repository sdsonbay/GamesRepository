using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetUserOfAddressByIdQueryHandler : IRequestHandler<GetUserOfAddressByIdQuery, GetUserOfAddressByIdOutput>
{
    private readonly IAddressService _addressService;

    public GetUserOfAddressByIdQueryHandler(IAddressService addressService)
    {
        _addressService = addressService;
    }

    public async Task<GetUserOfAddressByIdOutput> Handle(GetUserOfAddressByIdQuery request, CancellationToken cancellationToken)
    {
        return await _addressService.GetUserOfAddressByIdAsync(request, cancellationToken);
    }
}