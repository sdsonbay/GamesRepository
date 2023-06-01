using Gameshop.Domain.Models.Common;

namespace Gameshop.Domain.Models;

public class Publisher : BaseEntity<int>
{
    public string Name { get; set; }

    public List<Game> Games { get; set; }
}