using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Responses;
/// <summary>
/// Get User Of Credit Card By Id Response
/// </summary>
public class GetUserOfCreditCardByIdResponse
{
    /// <summary>
    /// First Name
    /// </summary>
    public string FirstName { get; set; }
    /// <summary>
    /// Last Name
    /// </summary>
    public string LastName { get; set; }
    /// <summary>
    /// Username
    /// </summary>
    public string Username { get; set; }
    /// <summary>
    /// Email
    /// </summary>
    public string Email { get; set; }
    /// <summary>
    /// Password
    /// </summary>
    public string? Password { get; set; }
}