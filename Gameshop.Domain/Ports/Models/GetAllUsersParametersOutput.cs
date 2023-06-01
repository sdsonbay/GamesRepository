using Gameshop.Domain.Dtos;

namespace Gameshop.Domain.Ports.Models;

public class GetAllUsersParametersOutput
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public List<AddressDto> Addresses { get; set; }
    public List<CreditCardDto> CreditCards { get; set; }
    public List<OrderDto> Orders { get; set; }
    public List<GameDto> Games { get; set; }
}