using Gameshop.Domain.Dtos;

namespace Gameshop.Domain.Ports.Models;

public class GetUserOfCreditCardByIdOutput
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string? Password { get; set; }
}