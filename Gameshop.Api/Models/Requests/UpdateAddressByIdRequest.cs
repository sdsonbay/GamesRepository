namespace Gameshop.Api.Models.Requests;
/// <summary>
/// Update Address By Id Request
/// </summary>
public class UpdateAddressByIdRequest
{
    /// <summary>
    /// Id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Country
    /// </summary>
    public string Country { get; set; }
    /// <summary>
    /// City
    /// </summary>
    public string City { get; set; }
    /// <summary>
    /// Town
    /// </summary>
    public string Town { get; set; }
    /// <summary>
    /// District
    /// </summary>
    public string District { get; set; }
    /// <summary>
    /// Street
    /// </summary>
    public string Street { get; set; }
    /// <summary>
    /// Address Detail
    /// </summary>
    public string AddressDetail { get; set; }
    /// <summary>
    /// Postal Code
    /// </summary>
    public string PostalCode { get; set; }
    /// <summary>
    /// User Id
    /// </summary>
    public int UserId { get; set; }
    /// <summary>
    /// Address Type
    /// </summary>
    public int AddressType { get; set; }
}