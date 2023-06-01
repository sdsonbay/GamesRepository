using Gameshop.Domain.Models;

namespace Gameshop.Api.Models.Requests;
/// <summary>
/// Create New Order Request
/// </summary>
public class CreateNewOrderRequest
{
    /// <summary>
    /// Order
    /// </summary>
    public Order Order { get; set; }
}