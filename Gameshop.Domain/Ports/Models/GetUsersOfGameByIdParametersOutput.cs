using Gameshop.Domain.Dtos;

namespace Gameshop.Domain.Ports.Models;

public class GetUsersOfGameByIdParametersOutput
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
}