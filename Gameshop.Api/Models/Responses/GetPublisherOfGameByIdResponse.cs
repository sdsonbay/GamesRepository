using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Responses;
/// <summary>
/// Get Publisher Of Game By Id Response
/// </summary>
public class GetPublisherOfGameByIdResponse
{
    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Games
    /// </summary>
    public List<GameDto>? Games { get; set; }
}