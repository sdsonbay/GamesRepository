using Gameshop.Domain.Dtos;

namespace Gameshop.Domain.Ports.Models;

public class GetGameByNameOutput
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int PublisherId { get; set; }
    public int CategoryId { get; set; }
}