using Gameshop.Domain.Models.Common;

namespace Gameshop.Domain.Models;

public class Game : BaseEntity<int>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int PublisherId { get; set; }
    public int CategoryId { get; set; }

    public List<User>? Users { get; set; }
    public List<Order>? Orders { get; set; }
    public Publisher? Publisher { get; set; }
    public Category? Category { get; set; }
}