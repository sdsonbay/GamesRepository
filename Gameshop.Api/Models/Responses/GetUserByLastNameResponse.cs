using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Responses;
/// <summary>
/// Get User By Last Name Response
/// </summary>
public class GetUserByLastNameResponse
{
    /// <summary>
    /// Users
    /// </summary>
    public List<UserDto> Users { get; set; }
}