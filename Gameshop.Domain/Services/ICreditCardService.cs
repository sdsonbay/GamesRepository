using Gameshop.Domain.Args;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;

namespace Gameshop.Domain.Services;

public interface ICreditCardService
{
    Task<GetAllCreditCardsOutput> GetAllCreditCardsAsync(CancellationToken cancellationToken = default);
    Task<GetCreditCardByIdOutput> GetCreditCardByIdAsync(GetCreditCardByIdArgs args, CancellationToken cancellationToken = default);
    Task<GetUserOfCreditCardByIdOutput> GetUserOfCreditCardByIdAsync(GetUserOfCreditCardByIdArgs args, CancellationToken cancellationToken = default);

    Task<CheckCreditCardExistsByIdOutput> CheckCreditCardExistsByIdAsync(CheckCreditCardExistsByIdArgs args, CancellationToken cancellationToken = default);
    Task<CreateNewCreditCardOutput> CreateNewCreditCardAsync(CreateNewCreditCardArgs args, CancellationToken cancellationToken = default);
    Task<UpdateCreditCardByIdOutput> UpdateCreditCardByIdAsync(UpdateCreditCardByIdArgs args, CancellationToken cancellationToken = default);
    Task<DeleteCreditCardByIdOutput> DeleteCreditCardByIdAsync(DeleteCreditCardByIdArgs args, CancellationToken cancellationToken = default);
}