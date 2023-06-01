using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Responses;
/// <summary>
/// Get All Games Response
/// </summary>
public class GetAllGamesResponse
{
    /// <summary>
    /// Games
    /// </summary>
    public List<GameDto> Games { get; set; }
}