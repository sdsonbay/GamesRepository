using Gameshop.Domain.Models;
using Gameshop.Domain.Persistence;
using Gameshop.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Gameshop.Infrastructure.Persistence;

public class GameRepository : IGameRepository
{
    private readonly ApplicationDbContext _context;

    public GameRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Game>> GetAllGamesAsync(CancellationToken cancellationToken = default)
    {
        return await _context.Games.ToListAsync(cancellationToken);
    }

    public async Task<Game> GetGameByIdAsync(int gameId, CancellationToken cancellationToken = default)
    {
        return await _context.Games.FirstOrDefaultAsync(g => g.Id == gameId, cancellationToken);
    }

    public async Task<Game> GetGameByNameAsync(string gameName, CancellationToken cancellationToken = default)
    {
        return await _context.Games.FirstOrDefaultAsync(g => g.Name == gameName, cancellationToken);
    }

    public async Task<Publisher> GetPublisherOfGameByIdAsync(int gameId, CancellationToken cancellationToken = default)
    {
        var game = await _context.Games.FirstOrDefaultAsync(g => g.Id == gameId, cancellationToken);
        return await _context.Publishers.FirstOrDefaultAsync(p => p.Id == game.PublisherId, cancellationToken);
    }

    public async Task<Category> GetCategoryOfGameByIdAsync(int gameId, CancellationToken cancellationToken = default)
    {
        var game = await _context.Games.FirstOrDefaultAsync(g => g.Id == gameId, cancellationToken);
        return await _context.Categories.FirstOrDefaultAsync(p => p.Id == game.CategoryId, cancellationToken);
    }

    public async Task<List<User>> GetUsersOfGameByIdAsync(int gameId, CancellationToken cancellationToken = default)
    {
        var game = await _context.Games.FirstOrDefaultAsync(g => g.Id == gameId, cancellationToken);
        var userIds = await _context.Orders.Where(o => o.GameId == gameId).Select(o => o.UserId).ToListAsync(cancellationToken);
        return await _context.Users.Where(u => userIds.Contains(u.Id)).ToListAsync(cancellationToken);
    }

    public async Task<List<Order>> GetOrdersOfGameByIdAsync(int gameId, CancellationToken cancellationToken = default)
    {
        var game = await _context.Games.FirstOrDefaultAsync(g => g.Id == gameId, cancellationToken);
        return await _context.Orders.Where(o => o.GameId == gameId).ToListAsync(cancellationToken);
    }

    public async Task<bool> CheckGameExistsByIdAsync(int gameId, CancellationToken cancellationToken = default)
    {
        return await _context.Games.AnyAsync(g => g.Id == gameId, cancellationToken);
    }

    public async Task<bool> CreateNewGameAsync(Game game, CancellationToken cancellationToken = default)
    {
        await _context.Games.AddAsync(game, cancellationToken);
        return await SaveAsync(cancellationToken);
    }

    public async Task<bool> UpdateGameByIdAsync(Game game, CancellationToken cancellationToken = default)
    {
        var gameToUpdate = await _context.Games.FirstOrDefaultAsync(g => g.Id == game.Id,cancellationToken);
        _context.Games.Update(gameToUpdate);
        return await SaveAsync(cancellationToken);
    }

    public async Task<bool> DeleteGameByIdAsync(int gameId, CancellationToken cancellationToken = default)
    {
        var gameToDelete = await _context.Games.FirstOrDefaultAsync(g => g.Id == gameId,cancellationToken);
        _context.Games.Remove(gameToDelete);
        return await SaveAsync(cancellationToken);
    }

    public async Task<bool> SaveAsync(CancellationToken cancellationToken = default)
    {
        var save = await _context.SaveChangesAsync(cancellationToken);
        return save > 0 ? true : false;
    }
}