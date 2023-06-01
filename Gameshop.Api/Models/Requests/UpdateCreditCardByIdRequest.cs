namespace Gameshop.Api.Models.Requests;
/// <summary>
/// Update Credit Card By Id Request
/// </summary>
public class UpdateCreditCardByIdRequest
{
    /// <summary>
    /// Id
    /// </summary>
    public int Id { get; set; }
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
    /// User Id
    /// </summary>
    public int UserId { get; set; }
}