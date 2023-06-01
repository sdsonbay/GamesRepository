namespace Gameshop.Domain.Dtos;

public class CreditCardDto
{
    public string CardNumber { get; set; }
    public string Cvv { get; set; }
    public decimal Balance { get; set; }
    public DateTime ExpirationDate { get; set; }
    public int UserId { get; set; }
    public UserDto? User { get; set; }
}