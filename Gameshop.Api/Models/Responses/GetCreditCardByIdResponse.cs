using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Responses;
/// <summary>
/// Get Credit Card By Id Response
/// </summary>
public class GetCreditCardByIdResponse
{
    /// <summary>
    /// Card Number
    /// </summary>
    public string CardNumber { get; set; }
    /// <summary>
    /// Cvv
    /// </summary>
    public string Cvv { get; set; }
    /// <summary>
    /// Balance
    /// </summary>
    public decimal Balance { get; set; }
    /// <summary>
    /// Expiration Date
    /// </summary>
    public DateTime ExpirationDate { get; set; }
    /// <summary>
    /// User
    /// </summary>
    public UserDto User { get; set; }
}