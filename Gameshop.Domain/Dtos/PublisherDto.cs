namespace Gameshop.Domain.Dtos;

public class PublisherDto
{
    public string Name { get; set; }

    public List<GameDto>? Games { get; set; }
}