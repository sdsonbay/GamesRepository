using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Responses;
/// <summary>
/// Get Orders Of Game By Id Response
/// </summary>
public class GetOrdersOfGameByIdResponse
{
    /// <summary>
    /// Orders
    /// </summary>
    public List<OrderDto> Orders { get; set; }
}