using Gameshop.Domain.Models;

namespace Gameshop.Domain.Persistence;

public interface IPublisherRepository
{
    Task<List<Publisher>> GetAllPublishersAsync(CancellationToken cancellationToken = default);
    Task<Publisher> GetPublisherByIdAsync(int publisherId, CancellationToken cancellationToken = default);
    Task<Publisher> GetPublisherByNameAsync(string publisherName, CancellationToken cancellationToken = default);
    Task<List<Game>> GetGamesOfPublisherByIdAsync(int publisherId, CancellationToken cancellationToken = default);

    Task<bool> CheckPublisherExistsByIdAsync(int publisherId, CancellationToken cancellationToken = default);
    Task<bool> CreateNewPublisherAsync(Publisher publisher, CancellationToken cancellationToken = default);
    Task<bool> UpdatePublisherByIdAsync(Publisher publisher, CancellationToken cancellationToken = default);
    Task<bool> DeletePublisherByIdAsync(int publisherId, CancellationToken cancellationToken = default);

    Task<bool> SaveAsync(CancellationToken cancellationToken = default);
}