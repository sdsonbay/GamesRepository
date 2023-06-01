using Gameshop.Domain.Ports.Models;
using Gameshop.Domain.Services;
using MediatR;

namespace Gameshop.Application.Commands;

public class DeleteAddressByIdCommandHandler : IRequestHandler<DeleteAddressByIdCommand, DeleteAddressByIdOutput>
{
    private readonly IAddressService _addressService;

    public DeleteAddressByIdCommandHandler(IAddressService addressService)
    {
        _addressService = addressService;
    }

    public async Task<DeleteAddressByIdOutput> Handle(DeleteAddressByIdCommand request, CancellationToken cancellationToken)
    {
        return await _addressService.DeleteAddressByIdAsync(request, cancellationToken);
    }
}