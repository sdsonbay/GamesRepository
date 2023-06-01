using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Requests;
/// <summary>
/// Update Order By Id Request
/// </summary>
public class UpdateOrderByIdRequest
{
    /// <summary>
    /// Id
    /// </summary>
    public int Id { get; set; }
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
}