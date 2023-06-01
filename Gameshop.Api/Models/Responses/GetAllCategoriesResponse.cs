using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Responses;
/// <summary>
/// Get All Categories Response
/// </summary>
public class GetAllCategoriesResponse
{
    /// <summary>
    /// Categories
    /// </summary>
    public List<CategoryDto> Categories { get; set; }
}