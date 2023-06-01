using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Responses;
/// <summary>
/// Get Users Of Game By Id Response
/// </summary>
public class GetUsersOfGameByIdResponse
{
    /// <summary>
    /// Users
    /// </summary>
    public List<UserDto> Users { get; set; }
}