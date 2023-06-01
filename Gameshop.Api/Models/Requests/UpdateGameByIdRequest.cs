using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Requests;
/// <summary>
/// Update Game By Id Request
/// </summary>
public class UpdateGameByIdRequest
{
    /// <summary>
    /// Id
    /// </summary>
    public int? Id { get; set; }
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
    /// Publisher Id
    /// </summary>
    public int PublisherId { get; set; }
    /// <summary>
    /// Category Id
    /// </summary>
    public int CategoryId { get; set; }
}