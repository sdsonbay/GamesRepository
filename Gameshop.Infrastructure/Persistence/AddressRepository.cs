using Gameshop.Domain.Models;
using Gameshop.Domain.Persistence;
using Gameshop.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Gameshop.Infrastructure.Persistence;

public class AddressRepository : IAddressRepository
{
    private readonly ApplicationDbContext _context;

    public AddressRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Address>> GetAllAddressesAsync(CancellationToken cancellationToken = default)
    {
        return await _context.Addresses.ToListAsync(cancellationToken);
    }

    public async Task<List<Address>> GetAddressesByCountryAsync(string country, CancellationToken cancellationToken = default)
    {
        return await _context.Addresses.Where(a => a.Country == country).ToListAsync(cancellationToken);
    }

    public async Task<List<Address>> GetAddressesByCityAsync(string city, CancellationToken cancellationToken = default)
    {
        return await _context.Addresses.Where(a => a.City == city).ToListAsync(cancellationToken);
    }

    public async Task<Address> GetAddressByIdAsync(int addressId, CancellationToken cancellationToken = default)
    {
        return await _context.Addresses.FirstOrDefaultAsync(a => a.Id == addressId, cancellationToken);
    }

    public async Task<User> GetUserOfAddressByIdAsync(int addressId, CancellationToken cancellationToken = default)
    {
        var address = await _context.Addresses.FirstOrDefaultAsync(a => a.Id == addressId);
        return await _context.Users.FirstOrDefaultAsync(a => a.Id == address.Id);
    }

    public async Task<bool> CheckAddressExistsByIdAsync(int addressId, CancellationToken cancellationToken = default)
    {
        return await _context.Addresses.AnyAsync(a => a.Id == addressId);
    }

    public async Task<bool> CreateNewAddressAsync(Address address, CancellationToken cancellationToken = default)
    {
        await _context.Addresses.AddAsync(address);
        return await SaveAsync(cancellationToken);
    }

    public async Task<bool> UpdateAddressByIdAsync(Address address, CancellationToken cancellationToken = default)
    {
        var addressToUpdate = await _context.Addresses.FirstOrDefaultAsync(a => a.Id == address.Id);
        _context.Addresses.Update(addressToUpdate);
        return await SaveAsync(cancellationToken);
    }

    public async Task<bool> DeleteAddressByIdAsync(int addressId, CancellationToken cancellationToken = default)
    {
        var addressToDelete = await _context.Addresses.FirstOrDefaultAsync(a => a.Id == addressId);
        _context.Addresses.Remove(addressToDelete);
        return await SaveAsync(cancellationToken);
    }

    public async Task<bool> SaveAsync(CancellationToken cancellationToken = default)
    {
        var save = await _context.SaveChangesAsync();
        return save > 0 ? true : false;
    }
}