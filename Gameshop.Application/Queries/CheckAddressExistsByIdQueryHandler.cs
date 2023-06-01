using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Queries;

public class CheckAddressExistsByIdQueryHandler : IRequestHandler<CheckAddressExistsByIdQuery, CheckAddressExistsByIdOutput>
{
    private readonly IAddressService _addressService;

    public CheckAddressExistsByIdQueryHandler(IAddressService addressService)
    {
        _addressService = addressService;
    }

    public async Task<CheckAddressExistsByIdOutput> Handle(CheckAddressExistsByIdQuery request, CancellationToken cancellationToken)
    {
        return await _addressService.CheckAddressExistsByIdAsync(request, cancellationToken);
    }
}