using Gameshop.Domain.Dtos;

namespace Gameshop.Domain.Ports.Models;

public class GetPublisherOfGameByIdOutput
{
    public string Name { get; set; }

    public List<GameDto>? Games { get; set; }
}