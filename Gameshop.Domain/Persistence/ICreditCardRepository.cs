using Gameshop.Domain.Models;

namespace Gameshop.Domain.Persistence;

public interface ICreditCardRepository
{
    Task<List<CreditCard>> GetAllCreditCardsAsync(CancellationToken cancellationToken = default);
    Task<CreditCard> GetCreditCardByIdAsync(int creditCardId, CancellationToken cancellationToken = default);
    Task<User> GetUserOfCreditCardByIdAsync(int creditCardId, CancellationToken cancellationToken = default);

    Task<bool> CheckCreditCardExistsByIdAsync(int creditCardId, CancellationToken cancellationToken = default);
    Task<bool> CreateNewCreditCardAsync(CreditCard creditCard, CancellationToken cancellationToken = default);
    Task<bool> UpdateCreditCardByIdAsync(CreditCard creditCard, CancellationToken cancellationToken = default);
    Task<bool> DeleteCreditCardByIdAsync(int creditCardId, CancellationToken cancellationToken = default);

    Task<bool> SaveAsync(CancellationToken cancellationToken = default);
}