using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Responses;
/// <summary>
/// Get Category By Id Response
/// </summary>
public class GetCategoryByIdResponse
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