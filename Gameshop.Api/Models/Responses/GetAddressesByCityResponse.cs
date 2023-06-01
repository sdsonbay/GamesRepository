using Gameshop.Api.Models.Enums;
using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Responses;
/// <summary>
/// Get Addresses By City Response
/// </summary>
public class GetAddressesByCityResponse
{
    /// <summary>
    /// Addresses
    /// </summary>
    public List<AddressDto> Addresses { get; set; }
}