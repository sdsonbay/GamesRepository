using Gameshop.Domain.Dtos;

namespace Gameshop.Domain.Args;

public class UpdateCreditCardByIdArgs
{
    public int Id { get; set; }
    public string CardNumber { get; set; }
    public string Cvv { get; set; }
    public decimal Balance { get; set; }
    public DateTime ExpirationDate { get; set; }
    public int UserId { get; set; }
}