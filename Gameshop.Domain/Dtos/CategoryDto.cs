namespace Gameshop.Domain.Dtos;

public class CategoryDto
{
    public string Name { get; set; }

    public List<GameDto>? Games { get; set; }
}