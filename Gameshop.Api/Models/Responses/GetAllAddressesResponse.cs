using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Responses;
/// <summary>
/// Get All Addresses Response
/// </summary>
public class GetAllAddressesResponse
{
    /// <summary>
    /// Addresses
    /// </summary>
    public List<AddressDto> Addressses { get; set; }
}