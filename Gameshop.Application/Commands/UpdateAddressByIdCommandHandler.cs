using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Commands;

public class UpdateAddressByIdCommandHandler : IRequestHandler<UpdateAddressByIdCommand, UpdateAddressByIdOutput>
{
    private readonly IAddressService _addressService;

    public UpdateAddressByIdCommandHandler(IAddressService addressService)
    {
        _addressService = addressService;
    }

    public async Task<UpdateAddressByIdOutput> Handle(UpdateAddressByIdCommand request, CancellationToken cancellationToken)
    {
        return await _addressService.UpdateAddressByIdAsync(request, cancellationToken);
    }
}