using Gameshop.Domain.Dtos;

namespace Gameshop.Domain.Ports.Models;

public class GetGamesOfUserByIdParametersOutput
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public DateTime ReleaseDate { get; set; }

    public List<UserDto> Users { get; set; }
    public List<OrderDto> Orders { get; set; }
    public PublisherDto Publisher { get; set; }
    public CategoryDto Category { get; set; }
}