using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Responses;
/// <summary>
/// Get Addresses By Country Response
/// </summary>
public class GetAddressesByCountryResponse
{
    /// <summary>
    /// Address
    /// </summary>
    public List<AddressDto> Addresses { get; set; }
}