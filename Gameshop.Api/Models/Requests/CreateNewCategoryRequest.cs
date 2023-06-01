using Gameshop.Domain.Models;

namespace Gameshop.Api.Models.Requests;
/// <summary>
/// Create New Category Request
/// </summary>
public class CreateNewCategoryRequest
{
    /// <summary>
    /// Category
    /// </summary>
    public Category Category { get; set; }
}