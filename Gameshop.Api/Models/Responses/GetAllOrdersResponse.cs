using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Responses;
/// <summary>
/// Get All Orders Response
/// </summary>
public class GetAllOrdersResponse
{
    /// <summary>
    /// Orders
    /// </summary>
    public List<OrderDto> Orders { get; set; }
}