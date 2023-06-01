using Gameshop.Domain.Dtos;

namespace Gameshop.Domain.Ports.Models;

public class GetCreditCardsOfUserByIdParametersOutput
{
    public string CardNumber { get; set; }
    public string Cvv { get; set; }
    public decimal Balance { get; set; }
    public DateTime ExpirationDate { get; set; }

    public UserDto User { get; set; }
}