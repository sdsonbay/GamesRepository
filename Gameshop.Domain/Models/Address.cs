using Gameshop.Domain.Enums;
using Gameshop.Domain.Models.Common;

namespace Gameshop.Domain.Models;

public class Address : BaseEntity<int>
{
    public string Country { get; set; }
    public string City { get; set; }
    public string Town { get; set; }
    public string District { get; set; }
    public string Street { get; set; }
    public string AddressDetail { get; set; }
    public string PostalCode { get; set; }
    public AddressType AddressType { get; set; }
    public int UserId { get; set; }

    public User? User { get; set; }
}