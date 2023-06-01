using Gameshop.Domain.Models;

namespace Gameshop.Api.Models.Requests;
/// <summary>
/// Create New Address Request
/// </summary>
public class CreateNewAddressRequest
{
    /// <summary>
    /// Address
    /// </summary>
    public Address Address { get; set; }
}