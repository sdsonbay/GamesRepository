using Gameshop.Domain.Models;

namespace Gameshop.Api.Models.Requests;
/// <summary>
/// Create New Game Request
/// </summary>
public class CreateNewGameRequest
{
    /// <summary>
    /// Game
    /// </summary>
    public Game Game { get; set; }
}