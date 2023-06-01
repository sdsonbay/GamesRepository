using Gameshop.Domain.Args;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;

namespace Gameshop.Domain.Services;

public interface IAddressService
{
    Task<GetAllAddressesOutput> GetAllAddressesAsync(CancellationToken cancellationToken = default);
    Task<GetAddressesByCountryOutput> GetAddressesByCountryAsync(GetAddressesByCountryArgs args, CancellationToken cancellationToken = default);
    Task<GetAddressesByCityOutput> GetAddressesByCityAsync(GetAddressesByCityArgs args, CancellationToken cancellationToken = default);
    Task<GetAddressByIdOutput> GetAddressByIdAsync(GetAddressByIdArgs args, CancellationToken cancellationToken = default);
    Task<GetUserOfAddressByIdOutput> GetUserOfAddressByIdAsync(GetUserOfAddressByIdArgs args, CancellationToken cancellationToken = default);

    Task<CheckAddressExistsByIdOutput> CheckAddressExistsByIdAsync(CheckAddressExistsByIdArgs args, CancellationToken cancellationToken = default);
    Task<CreateNewAddressOutput> CreateNewAddressAsync(CreateNewAddressArgs args, CancellationToken cancellationToken = default);
    Task<UpdateAddressByIdOutput> UpdateAddressByIdAsync(UpdateAddressByIdArgs args, CancellationToken cancellationToken = default);
    Task<DeleteAddressByIdOutput> DeleteAddressByIdAsync(DeleteAddressByIdArgs args, CancellationToken cancellationToken = default);
}