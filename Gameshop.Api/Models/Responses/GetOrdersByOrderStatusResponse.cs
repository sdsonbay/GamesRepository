using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Responses;
/// <summary>
/// Get Orders By Order Status Response
/// </summary>
public class GetOrdersByOrderStatusResponse
{
    /// <summary>
    /// Orders
    /// </summary>
    public List<OrderDto> Orders { get; set; }
}