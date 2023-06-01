using Gameshop.Domain.Dtos;

namespace Gameshop.Api.Models.Responses;
/// <summary>
/// Get All Publishers Response
/// </summary>
public class GetAllPublishersResponse
{
    /// <summary>
    /// Publishers
    /// </summary>
    public List<PublisherDto> Publishers { get; set; }
}