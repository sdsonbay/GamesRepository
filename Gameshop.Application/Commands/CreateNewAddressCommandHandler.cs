using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Commands;

public class CreateNewAddressCommandHandler : IRequestHandler<CreateNewAddressCommand, CreateNewAddressOutput>
{
    private readonly IAddressService _addressService;

    public CreateNewAddressCommandHandler(IAddressService addressService)
    {
        _addressService = addressService;
    }

    public async Task<CreateNewAddressOutput> Handle(CreateNewAddressCommand request, CancellationToken cancellationToken)
    {
        return await _addressService.CreateNewAddressAsync(request, cancellationToken);
    }
}