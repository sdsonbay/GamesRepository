using Gameshop.Domain.Args;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;

namespace Gameshop.Domain.Services;

public interface IPublisherService
{
    Task<GetAllPublishersOutput> GetAllPublishersAsync(CancellationToken cancellationToken = default);
    Task<GetPublisherByIdOutput> GetPublisherByIdAsync(GetPublisherByIdArgs args, CancellationToken cancellationToken = default);
    Task<GetPublisherByNameOutput> GetPublisherByNameAsync(GetPublisherByNameArgs args, CancellationToken cancellationToken = default);
    Task<GetGamesOfPublisherByIdOutput> GetGamesOfPublisherByIdAsync(GetGamesOfPublisherByIdArgs args, CancellationToken cancellationToken = default);
    Task<CheckPublisherExistsByIdOutput> CheckPublisherExistsByIdAsync(CheckPublisherExistsByIdArgs args, CancellationToken cancellationToken = default);
    Task<CreateNewPublisherOutput> CreateNewPublisherAsync(CreateNewPublisherArgs args, CancellationToken cancellationToken = default);
    Task<UpdatePublisherByIdOutput> UpdatePublisherByIdAsync(UpdatePublisherByIdArgs args, CancellationToken cancellationToken = default);
    Task<DeletePublisherByIdOutput> DeletePublisherByIdAsync(DeletePublisherByIdArgs args, CancellationToken cancellationToken = default);
}