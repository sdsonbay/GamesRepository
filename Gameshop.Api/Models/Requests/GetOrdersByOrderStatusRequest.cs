using Gameshop.Domain.Enums;

namespace Gameshop.Api.Models.Requests;
/// <summary>
/// Get Orders By Order Status Request
/// </summary>
public class GetOrdersByOrderStatusRequest
{
    /// <summary>
    /// Order Status 1 -> Completed
    /// </summary>
    public OrderStatus OrderStatus { get; set; }
}