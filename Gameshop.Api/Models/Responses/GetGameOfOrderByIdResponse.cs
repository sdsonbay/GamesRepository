using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Responses;
/// <summary>
/// Get Game Of Order By Id Response
/// </summary>
public class GetGameOfOrderByIdResponse
{
    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Description
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Price
    /// </summary>
    public decimal Price { get; set; }
    /// <summary>
    /// Release Date
    /// </summary>
    public DateTime ReleaseDate { get; set; }
    /// <summary>
    /// Users
    /// </summary>
    public List<UserDto>? Users { get; set; }
    /// <summary>
    /// Orders
    /// </summary>
    public List<OrderDto>? Orders { get; set; }
    /// <summary>
    /// Publisher
    /// </summary>
    public PublisherDto? Publisher { get; set; }
    /// <summary>
    /// Category
    /// </summary>
    public CategoryDto? Category { get; set; }
}