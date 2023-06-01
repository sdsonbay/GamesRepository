using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Responses;
/// <summary>
/// Get Category By Name Response
/// </summary>
public class GetCategoryByNameResponse
{
    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Games
    /// </summary>
    public List<GameDto> Games { get; set; }
}