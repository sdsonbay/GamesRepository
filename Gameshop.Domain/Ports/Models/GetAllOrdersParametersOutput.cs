using Gameshop.Domain.Dtos;
using Gameshop.Domain.Enums;

namespace Gameshop.Domain.Ports.Models;

public class GetAllOrdersParametersOutput
{
    public OrderStatus OrderStatus { get; set; }
    public DateTime DateCreated { get; set; }
    public int UserId { get; set; }
    public int GameId { get; set; }
    public UserDto? User { get; set; }
    public GameDto? Game { get; set; }
}