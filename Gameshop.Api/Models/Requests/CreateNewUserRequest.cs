using Gameshop.Domain.Models;

namespace Gameshop.Api.Models.Requests;
/// <summary>
/// Create New User Request
/// </summary>
public class CreateNewUserRequest
{
    /// <summary>
    /// User
    /// </summary>
    public User User { get; set; }
}