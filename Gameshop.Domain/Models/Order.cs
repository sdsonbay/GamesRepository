using Gameshop.Domain.Enums;
using Gameshop.Domain.Models.Common;

namespace Gameshop.Domain.Models;

public class Order : BaseEntity<int>
{
    public int OrderStatus { get; set; }
    public DateTime DateCreated { get; set; }
    public int UserId { get; set; }
    public int GameId { get; set; }

    public User? User { get; set; }
    public Game? Game { get; set; }
}