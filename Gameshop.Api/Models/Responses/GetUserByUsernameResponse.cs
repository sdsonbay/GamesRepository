using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Responses;
/// <summary>
/// Get User By Username Response
/// </summary>
public class GetUserByUsernameResponse
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
    public string Password { get; set; }
    /// <summary>
    /// Addresses
    /// </summary>
    public List<AddressDto> Addresses { get; set; }
    /// <summary>
    /// Credit Cards
    /// </summary>
    public List<CreditCardDto> CreditCards { get; set; }
    /// <summary>
    /// Orders
    /// </summary>
    public List<OrderDto> Orders { get; set; }
    /// <summary>
    /// Games
    /// </summary>
    public List<GameDto> Games { get; set; }
}