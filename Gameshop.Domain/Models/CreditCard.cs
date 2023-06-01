using Gameshop.Domain.Models.Common;

namespace Gameshop.Domain.Models;

public class CreditCard : BaseEntity<int>
{
    public string CardNumber { get; set; }
    public string Cvv { get; set; }
    public decimal Balance { get; set; }
    public DateTime ExpirationDate { get; set; }
    public int UserId { get; set; }

    public User? User { get; set; }
}