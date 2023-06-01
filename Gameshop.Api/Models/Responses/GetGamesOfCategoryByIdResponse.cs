using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Responses;
/// <summary>
/// Get Games Of Category By Id Response
/// </summary>
public class GetGamesOfCategoryByIdResponse
{
    /// <summary>
    /// Games
    /// </summary>
    public List<GameDto> Games { get; set; }
}