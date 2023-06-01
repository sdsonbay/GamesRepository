using Gameshop.Domain.Models;
using Gameshop.Domain.Persistence;
using Gameshop.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Gameshop.Infrastructure.Persistence;

public class CreditCardRepository : ICreditCardRepository
{
    private readonly ApplicationDbContext _context;

    public CreditCardRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<CreditCard>> GetAllCreditCardsAsync(CancellationToken cancellationToken = default)
    {
        return await _context.CreditCards.ToListAsync(cancellationToken);
    }

    public async Task<CreditCard> GetCreditCardByIdAsync(int creditCardId, CancellationToken cancellationToken = default)
    {
        return await _context.CreditCards.FirstOrDefaultAsync(c => c.Id == creditCardId, cancellationToken);
    }

    public async Task<User> GetUserOfCreditCardByIdAsync(int creditCardId, CancellationToken cancellationToken = default)
    {
        var creditCard = await _context.CreditCards.FirstOrDefaultAsync(c => c.Id == creditCardId, cancellationToken);
        return await _context.Users.FirstOrDefaultAsync(u => u.Id == creditCard.UserId, cancellationToken);
    }

    public async Task<bool> CheckCreditCardExistsByIdAsync(int creditCardId, CancellationToken cancellationToken = default)
    {
        return await _context.CreditCards.AnyAsync(c => c.Id == creditCardId, cancellationToken);
    }

    public async Task<bool> CreateNewCreditCardAsync(CreditCard creditCard, CancellationToken cancellationToken = default)
    {
        await _context.CreditCards.AddAsync(creditCard, cancellationToken);
        return await SaveAsync(cancellationToken);
    }

    public async Task<bool> UpdateCreditCardByIdAsync(CreditCard creditCard, CancellationToken cancellationToken = default)
    {
        var creditCardToUpdate = await _context.CreditCards.FirstOrDefaultAsync(c => c.Id == creditCard.Id, cancellationToken);
        _context.CreditCards.Update(creditCardToUpdate);
        return await SaveAsync(cancellationToken);
    }

    public async Task<bool> DeleteCreditCardByIdAsync(int creditCardId, CancellationToken cancellationToken = default)
    {
        var creditCardToDelete = await _context.CreditCards.FirstOrDefaultAsync(c => c.Id == creditCardId, cancellationToken);
        _context.CreditCards.Remove(creditCardToDelete);
        return await SaveAsync(cancellationToken);
    }

    public async Task<bool> SaveAsync(CancellationToken cancellationToken = default)
    {
        var save = await _context.SaveChangesAsync(cancellationToken);
        return save > 0 ? true : false;
    }
}