using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Responses;
/// <summary>
/// Get All Users Response
/// </summary>
public class GetAllUsersResponse
{
    /// <summary>
    /// Users
    /// </summary>
    public List<UserDto> Users { get; set; }
}