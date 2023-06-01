using Gameshop.Domain.Args;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;

namespace Gameshop.Domain.Services;

public interface IGameService
{
    Task<GetAllGamesOutput> GetAllGamesAsync(CancellationToken cancellationToken = default);
    Task<GetGameByIdOutput> GetGameByIdAsync(GetGameByIdArgs args, CancellationToken cancellationToken = default);
    Task<GetGameByNameOutput> GetGameByNameAsync(GetGameByNameArgs args, CancellationToken cancellationToken = default);
    Task<GetPublisherOfGameByIdOutput> GetPublisherOfGameByIdAsync(GetPublisherOfGameByIdArgs args, CancellationToken cancellationToken = default);
    Task<GetCategoryOfGameByIdOutput> GetCategoryOfGameByIdAsync(GetCategoryOfGameByIdArgs args, CancellationToken cancellationToken = default);
    Task<GetUsersOfGameByIdOutput> GetUsersOfGameByIdAsync(GetUsersOfGameByIdArgs args, CancellationToken cancellationToken = default);
    Task<GetOrdersOfGameByIdOutput> GetOrdersOfGameByIdAsync(GetOrdersOfGameByIdArgs args, CancellationToken cancellationToken = default);

    Task<CheckGameExistsByIdOutput> CheckGameExistsByIdAsync(CheckGameExistsByIdArgs args, CancellationToken cancellationToken = default);
    Task<CreateNewGameOutput> CreateNewGameAsync(CreateNewGameArgs args, CancellationToken cancellationToken = default);
    Task<UpdateGameByIdOutput> UpdateGameByIdAsync(UpdateGameByIdArgs args, CancellationToken cancellationToken = default);
    Task<DeleteGameByIdOutput> DeleteGameByIdAsync(DeleteGameByIdArgs args, CancellationToken cancellationToken = default);
}