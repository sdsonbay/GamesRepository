using Gameshop.Domain.Models;

namespace Gameshop.Domain.Args;

public class CreateNewCreditCardArgs
{
    public CreditCard CreditCard { get; set; }
}