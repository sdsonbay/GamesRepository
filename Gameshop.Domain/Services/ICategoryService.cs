using Gameshop.Domain.Args;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;

namespace Gameshop.Domain.Services;

public interface ICategoryService
{
    Task<GetAllCategoriesOutput> GetAllCategoriesAsync(CancellationToken cancellationToken = default);
    Task<GetCategoryByIdOutput> GetCategoryByIdAsync(GetCategoryByIdArgs args, CancellationToken cancellationToken = default);
    Task<GetCategoryByNameOutput> GetCategoryByNameAsync(GetCategoryByNameArgs args, CancellationToken cancellationToken = default);
    Task<GetGamesOfCategoryByIdOutput> GetGamesOfCategoryByIdAsync(GetGamesOfCategoryByIdArgs args, CancellationToken cancellationToken = default);

    Task<CheckCategoryExistsByIdOutput> CheckCategoryExistsByIdAsync(CheckCategoryExistsByIdArgs args, CancellationToken cancellationToken = default);
    Task<CreateNewCategoryOutput> CreateNewCategoryAsync(CreateNewCategoryArgs args, CancellationToken cancellationToken = default);
    Task<UpdateCategoryByIdOutput> UpdateCategoryByIdAsync(UpdateCategoryByIdArgs args, CancellationToken cancellationToken = default);
    Task<DeleteCategoryByIdOutput> DeleteCategoryByIdAsync(DeleteCategoryByIdArgs args, CancellationToken cancellationToken = default);
}