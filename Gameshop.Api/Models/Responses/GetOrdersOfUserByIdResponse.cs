using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Responses;
/// <summary>
/// Get Orders Of User By Id Response
/// </summary>
public class GetOrdersOfUserByIdResponse
{
    /// <summary>
    /// Orders
    /// </summary>
    public List<OrderDto> Orders { get; set; }
}