using Gameshop.Domain.Models;

namespace Gameshop.Api.Models.Requests;
/// <summary>
/// Create New Credit Card Request
/// </summary>
public class CreateNewCreditCardRequest
{
    /// <summary>
    /// Credit Card
    /// </summary>
    public CreditCard CreditCard { get; set; }
}