using Gameshop.Domain.Models;

namespace Gameshop.Domain.Args;

public class CreateNewUserArgs
{
    public User User { get; set; }
}