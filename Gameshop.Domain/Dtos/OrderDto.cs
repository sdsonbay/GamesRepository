using Gameshop.Domain.Enums;

namespace Gameshop.Domain.Dtos;

public class OrderDto
{
    public int OrderStatus { get; set; }
    public DateTime DateCreated { get; set; }
    public int UserId { get; set; }
    public int GameId { get; set; }

    public UserDto? User { get; set; }
    public GameDto? Game { get; set; }
}