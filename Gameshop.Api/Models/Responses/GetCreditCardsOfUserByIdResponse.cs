using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Responses;
/// <summary>
/// Get Credit Cards Of User By Id Response
/// </summary>
public class GetCreditCardsOfUserByIdResponse
{
    /// <summary>
    /// Credit Cards
    /// </summary>
    public List<CreditCardDto> CreditCards { get; set; }
}