using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Requests;
/// <summary>
/// Update Category By Id Request
/// </summary>
public class UpdateCategoryByIdRequest
{
    /// <summary>
    /// Id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Games
    /// </summary>
    public List<GameDto>? Games { get; set; }
}