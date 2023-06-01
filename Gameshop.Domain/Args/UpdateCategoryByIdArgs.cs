using Gameshop.Domain.Dtos;

namespace Gameshop.Domain.Args;

public class UpdateCategoryByIdArgs
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<GameDto>? Games { get; set; }
}