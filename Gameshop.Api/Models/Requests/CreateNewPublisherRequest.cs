using Gameshop.Domain.Models;

namespace Gameshop.Api.Models.Requests;
/// <summary>
/// Create New Publisher Request
/// </summary>
public class CreateNewPublisherRequest
{
    /// <summary>
    /// Publisher
    /// </summary>
    public Publisher? Publisher { get; set; }
}