using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Responses;
/// <summary>
/// Get Addresses Of User By Id Response
/// </summary>
public class GetAddressesOfUserByIdResponse
{
    /// <summary>
    /// Addresses
    /// </summary>
    public List<AddressDto> Addressses { get; set; }
}