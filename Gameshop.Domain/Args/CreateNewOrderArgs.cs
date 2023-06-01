using Gameshop.Domain.Models;

namespace Gameshop.Domain.Args;

public class CreateNewOrderArgs
{
    public Order Order { get; set; }
}