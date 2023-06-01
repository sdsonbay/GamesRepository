using Gameshop.Domain.Models;

namespace Gameshop.Domain.Persistence;

public interface IGameRepository
{
    Task<List<Game>> GetAllGamesAsync(CancellationToken cancellationToken = default);
    Task<Game> GetGameByIdAsync(int gameId, CancellationToken cancellationToken = default);
    Task<Game> GetGameByNameAsync(string gameName, CancellationToken cancellationToken = default);
    Task<Publisher> GetPublisherOfGameByIdAsync(int gameId, CancellationToken cancellationToken = default);
    Task<Category> GetCategoryOfGameByIdAsync(int gameId, CancellationToken cancellationToken = default);
    Task<List<User>> GetUsersOfGameByIdAsync(int gameId, CancellationToken cancellationToken = default);
    Task<List<Order>> GetOrdersOfGameByIdAsync(int gameId, CancellationToken cancellationToken = default);

    Task<bool> CheckGameExistsByIdAsync(int gameId, CancellationToken cancellationToken = default);
    Task<bool> CreateNewGameAsync(Game game, CancellationToken cancellationToken = default);
    Task<bool> UpdateGameByIdAsync(Game game, CancellationToken cancellationToken = default);
    Task<bool> DeleteGameByIdAsync(int gameId, CancellationToken cancellationToken = default);

    Task<bool> SaveAsync(CancellationToken cancellationToken = default);
}