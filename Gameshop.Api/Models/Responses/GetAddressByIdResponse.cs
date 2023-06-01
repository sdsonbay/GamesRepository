using Gameshop.Api.Models.Enums;
using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Responses;
/// <summary>
/// Get Address By Id
/// </summary>
public class GetAddressByIdResponse
{
    /// <summary>
    /// Country
    /// </summary>
    public string Country { get; set; }
    /// <summary>
    /// City
    /// </summary>
    public string City { get; set; }
    /// <summary>
    /// Town
    /// </summary>
    public string Town { get; set; }
    /// <summary>
    /// District
    /// </summary>
    public string District { get; set; }
    /// <summary>
    /// Street
    /// </summary>
    public string Street { get; set; }
    /// <summary>
    /// Address Detail
    /// </summary>
    public string AddressDetail { get; set; }
    /// <summary>
    /// Postal Code
    /// </summary>
    public string PostalCode { get; set; }
    /// <summary>
    /// Address Type
    /// </summary>
    public int AddressType { get; set; }
    /// <summary>
    /// User
    /// </summary>
    public UserDto User { get; set; }
}