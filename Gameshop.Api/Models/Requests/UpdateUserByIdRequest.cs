namespace Gameshop.Api.Models.Requests;
/// <summary>
/// Update User By Id Request
/// </summary>
public class UpdateUserByIdRequest
{
    /// <summary>
    /// Id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// First Name
    /// </summary>
    public string FirstName { get; set; }
    /// <summary>
    /// Last Name
    /// </summary>
    public string LastName { get; set; }
    /// <summary>
    /// Email
    /// </summary>
    public string Email { get; set; }
    /// <summary>
    /// Username
    /// </summary>
    public string Username { get; set; }
    /// <summary>
    /// Password
    /// </summary>
    public string Password { get; set; }
}