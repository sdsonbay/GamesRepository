using Gameshop.Domain.Dtos;

namespace Gameshop.Domain.Ports.Models;

public class GetAllPublishersParametersOutput
{
    public string Name { get; set; }

    public List<GameDto> Games { get; set; }
}