using Gameshop.Domain.Models;

namespace Gameshop.Domain.Persistence;

public interface ICategoryRepository
{
    Task<List<Category>> GetAllCategoriesAsync(CancellationToken cancellationToken = default);
    Task<Category> GetCategoryByIdAsync(int categoryId, CancellationToken cancellationToken = default);
    Task<Category> GetCategoryByNameAsync(string categoryName, CancellationToken cancellationToken = default);
    Task<List<Game>> GetGamesOfCategoryByIdAsync(int categoryId, CancellationToken cancellationToken = default);

    Task<bool> CheckCategoryExistsByIdAsync(int categoryId, CancellationToken cancellationToken = default);
    Task<bool> CreateNewCategoryAsync(Category category, CancellationToken cancellationToken = default);
    Task<bool> UpdateCategoryByIdAsync(Category category, CancellationToken cancellationToken = default);
    Task<bool> DeleteCategoryByIdAsync(int categoryId, CancellationToken cancellationToken = default);

    Task<bool> SaveAsync(CancellationToken cancellationToken = default);
}