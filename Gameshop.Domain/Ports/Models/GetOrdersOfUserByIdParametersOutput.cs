using Gameshop.Domain.Dtos;
using Gameshop.Domain.Enums;

namespace Gameshop.Domain.Ports.Models;

public class GetOrdersOfUserByIdParametersOutput
{
    public OrderStatus OrderStatus { get; set; }
    public DateTime DateCreated { get; set; }

    public UserDto User { get; set; }
    public GameDto Game { get; set; }
}