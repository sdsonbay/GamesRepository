using Gameshop.Domain.Models.Common;

namespace Gameshop.Domain.Models;

public class User : BaseEntity<int>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public List<Address>? Addresses { get; set; }
    public List<CreditCard>? CreditCards { get; set; }
    public List<Order>? Orders { get; set; }
    public List<Game>? Games { get; set; }
}