using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Responses;
/// <summary>
/// Get User By First Name Response
/// </summary>
public class GetUserByFirstNameResponse
{
    /// <summary>
    /// Users
    /// </summary>
    public List<UserDto> Users { get; set; }
}