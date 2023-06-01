using Gameshop.Domain.Dtos;
using Gameshop.Domain.Enums;

namespace Gameshop.Domain.Ports.Models;

public class GetAddressByIdOutput
{
    public string Country { get; set; }
    public string City { get; set; }
    public string Town { get; set; }
    public string District { get; set; }
    public string Street { get; set; }
    public string AddressDetail { get; set; }
    public string PostalCode { get; set; }
    public int AddressType { get; set; }

    public UserDto User { get; set; }
}