using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Responses;
/// <summary>
/// Get All Credit Cards Response
/// </summary>
public class GetAllCreditCardsResponse
{
    /// <summary>
    /// Credit Cards
    /// </summary>
    public List<CreditCardDto> CreditCards { get; set; }
}