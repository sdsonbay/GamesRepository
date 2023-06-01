using Gameshop.Domain.Models;
using Gameshop.Domain.Persistence;
using Gameshop.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Gameshop.Infrastructure.Persistence;

public class PublisherRepository : IPublisherRepository
{
    private readonly ApplicationDbContext _context;

    public PublisherRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Publisher>> GetAllPublishersAsync(CancellationToken cancellationToken = default)
    {
        return await _context.Publishers.ToListAsync(cancellationToken);
    }

    public async Task<Publisher> GetPublisherByIdAsync(int publisherId, CancellationToken cancellationToken = default)
    {
        return await _context.Publishers.FirstOrDefaultAsync(p => p.Id == publisherId, cancellationToken);
    }

    public async Task<Publisher> GetPublisherByNameAsync(string publisherName, CancellationToken cancellationToken = default)
    {
        return await _context.Publishers.FirstOrDefaultAsync(p => p.Name == publisherName, cancellationToken);
    }

    public async Task<List<Game>> GetGamesOfPublisherByIdAsync(int publisherId, CancellationToken cancellationToken = default)
    {
        return await _context.Games.Where(g => g.PublisherId == publisherId).ToListAsync(cancellationToken);
    }

    public async Task<bool> CheckPublisherExistsByIdAsync(int publisherId, CancellationToken cancellationToken = default)
    {
        return await _context.Publishers.AnyAsync(p => p.Id == publisherId, cancellationToken);
    }

    public async Task<bool> CreateNewPublisherAsync(Publisher publisher, CancellationToken cancellationToken = default)
    {
        await _context.Publishers.AddAsync(publisher, cancellationToken);
        return await SaveAsync(cancellationToken);
    }

    public async Task<bool> UpdatePublisherByIdAsync(Publisher publisher, CancellationToken cancellationToken = default)
    {
        var publisherToUpdate = await _context.Publishers.FirstOrDefaultAsync(p => p.Id == publisher.Id,cancellationToken);
        _context.Publishers.Update(publisherToUpdate);
        return await SaveAsync(cancellationToken);
    }

    public async Task<bool> DeletePublisherByIdAsync(int publisherId, CancellationToken cancellationToken = default)
    {
        var publisherToDelete = await _context.Publishers.FirstOrDefaultAsync(p => p.Id == publisherId,cancellationToken);
        _context.Publishers.Remove(publisherToDelete);
        return await SaveAsync(cancellationToken);
    }

    public async Task<bool> SaveAsync(CancellationToken cancellationToken = default)
    {
        var save = await _context.SaveChangesAsync(cancellationToken);
        return save > 0 ? true : false;
    }
}