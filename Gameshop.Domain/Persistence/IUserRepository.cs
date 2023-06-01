using Gameshop.Domain.Models;

namespace Gameshop.Domain.Persistence;

public interface IUserRepository
{
    Task<List<User>> GetAllUsersAsync(CancellationToken cancellationToken = default);
    Task<User> GetUserByIdAsync(int userId, CancellationToken cancellationToken = default);
    Task<User> GetUserByUsernameAsync(string username, CancellationToken cancellationToken = default);
    Task<User> GetUserByEmailAsync(string email, CancellationToken cancellationToken = default);
    Task<List<User>> GetUsersByFirstNameAsync(string firstName, CancellationToken cancellationToken = default);
    Task<List<User>> GetUsersByLastNameAsync(string lastName, CancellationToken cancellationToken = default);
    Task<List<Address>> GetAddressesOfUserByIdAsync(int userId, CancellationToken cancellationToken = default);
    Task<List<CreditCard>> GetCreditCardsOfUserByIdAsync(int userId, CancellationToken cancellationToken = default);
    Task<List<Order>> GetOrdersOfUserByIdAsync(int userId, CancellationToken cancellationToken = default);
    Task<List<Game>> GetGamesOfUserByIdAsync(int userId, CancellationToken cancellationToken = default);

    Task<bool> CheckUserExistsByIdAsync(int userId, CancellationToken cancellationToken = default);
    Task<bool> CreateNewUserAsync(User user, CancellationToken cancellationToken = default);
    Task<bool> UpdateUserByIdAsync(User user, CancellationToken cancellationToken = default);
    Task<bool> DeleteUserByIdAsync(int userId, CancellationToken cancellationToken = default);

    Task<bool> SaveAsync(CancellationToken cancellationToken = default);
}