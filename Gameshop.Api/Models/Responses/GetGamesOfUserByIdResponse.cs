using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Responses;
/// <summary>
/// Get Games Of User By Id Response
/// </summary>
public class GetGamesOfUserByIdResponse
{
    /// <summary>
    /// Games
    /// </summary>
    public List<GameDto> Games { get; set; }
}