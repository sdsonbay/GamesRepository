using Gameshop.Api.Models.Enums;
using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Responses;
/// <summary>
/// Get Order By Id Response
/// </summary>
public class GetOrderByIdResponse
{
    /// <summary>
    /// Order Status
    /// </summary>
    public int OrderStatus { get; set; }
    /// <summary>
    /// Date Created
    /// </summary>
    public DateTime DateCreated { get; set; }
    /// <summary>
    /// User Id
    /// </summary>
    public int UserId { get; set; }
    /// <summary>
    /// Game Id
    /// </summary>
    public int GameId { get; set; }
    /// <summary>
    /// User
    /// </summary>
    public UserDto? User { get; set; }
    /// <summary>
    /// Game
    /// </summary>
    public GameDto? Game { get; set; }
}