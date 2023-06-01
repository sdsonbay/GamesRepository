using Gameshop.Domain.Models;
using Gameshop.Domain.Persistence;
using Gameshop.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Gameshop.Infrastructure.Persistence;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<User>> GetAllUsersAsync(CancellationToken cancellationToken = default)
    {
        return await _context.Users.OrderBy(u => u.Id).ToListAsync(cancellationToken);
    }

    public async Task<User> GetUserByIdAsync(int userId, CancellationToken cancellationToken = default)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Id == userId, cancellationToken);
    }

    public async Task<User> GetUserByUsernameAsync(string username, CancellationToken cancellationToken = default)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Username == username, cancellationToken);
    }

    public async Task<User> GetUserByEmailAsync(string email, CancellationToken cancellationToken = default)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Email == email, cancellationToken);
    }

    public async Task<List<User>> GetUsersByFirstNameAsync(string firstName, CancellationToken cancellationToken = default)
    {
        return await _context.Users.Where(u => u.FirstName == firstName).ToListAsync(cancellationToken);
    }

    public async Task<List<User>> GetUsersByLastNameAsync(string lastName, CancellationToken cancellationToken = default)
    {
        return await _context.Users.Where(u => u.LastName == lastName).ToListAsync(cancellationToken);
    }

    public async Task<List<Address>> GetAddressesOfUserByIdAsync(int userId, CancellationToken cancellationToken = default)
    {
        return await _context.Addresses.Where(a => a.UserId == userId).ToListAsync(cancellationToken);
    }

    public async Task<List<CreditCard>> GetCreditCardsOfUserByIdAsync(int userId, CancellationToken cancellationToken = default)
    {
        return await _context.CreditCards.Where(c => c.UserId == userId).ToListAsync(cancellationToken);
    }

    public async Task<List<Order>> GetOrdersOfUserByIdAsync(int userId, CancellationToken cancellationToken = default)
    {
        return await _context.Orders.Where(o => o.UserId == userId).ToListAsync(cancellationToken);
    }

    public async Task<List<Game>> GetGamesOfUserByIdAsync(int userId, CancellationToken cancellationToken = default)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId, cancellationToken);
        return user.Games;
    }

    public async Task<bool> CheckUserExistsByIdAsync(int userId, CancellationToken cancellationToken = default)
    {
        return await _context.Users.AnyAsync(u => u.Id == userId, cancellationToken);
    }

    public async Task<bool> CreateNewUserAsync(User user, CancellationToken cancellationToken = default)
    {
        await _context.Users.AddAsync(user, cancellationToken);
        return await SaveAsync(cancellationToken);
    }

    public async Task<bool> UpdateUserByIdAsync(User user, CancellationToken cancellationToken = default)
    {
        var userToUpdate = await _context.Users.FirstOrDefaultAsync(u => u.Id == user.Id, cancellationToken);
        _context.Users.Update(userToUpdate);
        return await SaveAsync(cancellationToken);
    }

    public async Task<bool> DeleteUserByIdAsync(int userId, CancellationToken cancellationToken = default)
    {
        var userToDelete = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId, cancellationToken);
        _context.Users.Remove(userToDelete);
        return await SaveAsync(cancellationToken);
    }

    public async Task<bool> SaveAsync(CancellationToken cancellationToken = default)
    {
        var save = await _context.SaveChangesAsync(cancellationToken);
        return save > 0 ? true : false;
    }
}