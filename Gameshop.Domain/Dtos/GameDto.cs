namespace Gameshop.Domain.Dtos;

public class GameDto
{
    public int? Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int PublisherId { get; set; }
    public int CategoryId { get; set; }
}