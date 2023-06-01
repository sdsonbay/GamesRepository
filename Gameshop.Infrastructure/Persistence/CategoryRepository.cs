using Gameshop.Domain.Models;
using Gameshop.Domain.Persistence;
using Gameshop.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Gameshop.Infrastructure.Persistence;

public class CategoryRepository : ICategoryRepository
{
    private readonly ApplicationDbContext _context;

    public CategoryRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Category>> GetAllCategoriesAsync(CancellationToken cancellationToken = default)
    {
        return await _context.Categories.ToListAsync(cancellationToken);
    }

    public async Task<Category> GetCategoryByIdAsync(int categoryId, CancellationToken cancellationToken = default)
    {
        return await _context.Categories.FirstOrDefaultAsync(c => c.Id == categoryId, cancellationToken);
    }

    public async Task<Category> GetCategoryByNameAsync(string categoryName, CancellationToken cancellationToken = default)
    {
        return await _context.Categories.FirstOrDefaultAsync(c => c.Name == categoryName, cancellationToken);
    }

    public async Task<List<Game>> GetGamesOfCategoryByIdAsync(int categoryId, CancellationToken cancellationToken = default)
    {
        return await _context.Games.Where(g => g.CategoryId == categoryId).ToListAsync(cancellationToken);
    }

    public async Task<bool> CheckCategoryExistsByIdAsync(int categoryId, CancellationToken cancellationToken = default)
    {
        return await _context.Categories.AnyAsync(c => c.Id == categoryId, cancellationToken);
    }

    public async Task<bool> CreateNewCategoryAsync(Category category, CancellationToken cancellationToken = default)
    {
        await _context.Categories.AddAsync(category, cancellationToken);
        return await SaveAsync(cancellationToken);
    }

    public async Task<bool> UpdateCategoryByIdAsync(Category category, CancellationToken cancellationToken = default)
    {
        var categoryToUpdate = await _context.Categories.FirstOrDefaultAsync(c => c.Id == category.Id, cancellationToken);
        _context.Categories.Update(categoryToUpdate);
        return await SaveAsync(cancellationToken);
    }

    public async Task<bool> DeleteCategoryByIdAsync(int categoryId, CancellationToken cancellationToken = default)
    {
        var categoryToDelete = await _context.Categories.FirstOrDefaultAsync(c => c.Id == categoryId, cancellationToken);
        _context.Categories.Remove(categoryToDelete);
        return await SaveAsync(cancellationToken);
    }

    public async Task<bool> SaveAsync(CancellationToken cancellationToken = default)
    {
        var save = await _context.SaveChangesAsync(cancellationToken);
        return save > 0 ? true : false;
    }
}