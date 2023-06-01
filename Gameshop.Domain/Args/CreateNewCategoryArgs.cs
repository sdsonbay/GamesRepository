using Gameshop.Domain.Models;

namespace Gameshop.Domain.Args;

public class CreateNewCategoryArgs
{
    public Category Category { get; set; }
}