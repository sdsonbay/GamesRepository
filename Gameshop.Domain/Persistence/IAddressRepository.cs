using Gameshop.Domain.Models;

namespace Gameshop.Domain.Persistence;

public interface IAddressRepository
{
    Task<List<Address>> GetAllAddressesAsync(CancellationToken cancellationToken = default);
    Task<List<Address>> GetAddressesByCountryAsync(string country, CancellationToken cancellationToken = default);
    Task<List<Address>> GetAddressesByCityAsync(string city, CancellationToken cancellationToken = default);
    Task<Address> GetAddressByIdAsync(int addressId, CancellationToken cancellationToken = default);
    Task<User> GetUserOfAddressByIdAsync(int addressId, CancellationToken cancellationToken = default);

    Task<bool> CheckAddressExistsByIdAsync(int addressId, CancellationToken cancellationToken = default);
    Task<bool> CreateNewAddressAsync(Address address, CancellationToken cancellationToken = default);
    Task<bool> UpdateAddressByIdAsync(Address address, CancellationToken cancellationToken = default);
    Task<bool> DeleteAddressByIdAsync(int addressId, CancellationToken cancellationToken = default);

    Task<bool> SaveAsync(CancellationToken cancellationToken = default);
}