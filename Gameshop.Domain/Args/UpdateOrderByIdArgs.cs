using Gameshop.Domain.Dtos;
using Gameshop.Domain.Enums;

namespace Gameshop.Domain.Args;

public class UpdateOrderByIdArgs
{
    public int Id { get; set; }
    public OrderStatus OrderStatus { get; set; }
    public DateTime DateCreated { get; set; }
    public int UserId { get; set; }
    public int GameId { get; set; }
}