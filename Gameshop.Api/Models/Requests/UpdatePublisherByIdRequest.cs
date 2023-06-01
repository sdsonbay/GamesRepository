namespace Gameshop.Api.Models.Requests;
/// <summary>
/// Update Publisher By Id Request
/// </summary>
public class UpdatePublisherByIdRequest
{
    /// <summary>
    /// Id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; }
}