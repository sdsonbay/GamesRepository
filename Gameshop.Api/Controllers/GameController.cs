using AutoMapper;
using Gameshop.Api.Models.Requests;
using Gameshop.Api.Models.Responses;
using Gameshop.Application.Commands;
using Gameshop.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Gameshop.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GameController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public GameController(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }
    
    /// <summary>
    /// Get All Games
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("all")]
    [ProducesResponseType(typeof(GetAllGamesResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllGames(CancellationToken cancellationToken)
    {
        var query = new GetAllGamesQuery();
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<GetAllGamesResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get Game By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("get-by-id")]
    [ProducesResponseType(typeof(GetGameByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetGameById([FromQuery] GetGameByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<GetGameByIdQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<GetGameByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get Game By Name
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("get-by-name")]
    [ProducesResponseType(typeof(GetGameByNameResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetGameByName([FromQuery] GetGameByNameRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<GetGameByNameQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<GetGameByNameResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get Publisher Of Game By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("publisher")]
    [ProducesResponseType(typeof(GetPublisherOfGameByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetPublisherOfGameById([FromQuery] GetPublisherOfGameByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<GetPublisherOfGameByIdQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<GetPublisherOfGameByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get Category Of Game By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("category")]
    [ProducesResponseType(typeof(GetCategoryOfGameByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetCategoryOfGameById([FromQuery] GetCategoryOfGameByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<GetCategoryOfGameByIdQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<GetCategoryOfGameByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get Users Of Game By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("users")]
    [ProducesResponseType(typeof(GetUsersOfGameByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetUsersOfGameById([FromQuery] GetUsersOfGameByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<GetUsersOfGameByIdQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<GetUsersOfGameByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get Orders Of Game By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("orders")]
    [ProducesResponseType(typeof(GetOrdersOfGameByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetOrdersOfGameById([FromQuery] GetOrdersOfGameByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<GetOrdersOfGameByIdQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<GetOrdersOfGameByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Check Game Exists By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("check-exists")]
    [ProducesResponseType(typeof(CheckGameExistsByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> CheckGameExistsById([FromQuery] CheckGameExistsByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<CheckGameExistsByIdQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<CheckGameExistsByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Create New Game
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost]
    [ProducesResponseType(typeof(CreateNewGameResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> CreateNewGame([FromBody] CreateNewGameRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<CreateNewGameCommand>(request);
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<CreateNewGameResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Update Game By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPut]
    [ProducesResponseType(typeof(UpdateGameByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> UpdateGameById([FromBody] UpdateGameByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<UpdateGameByIdCommand>(request);
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<UpdateGameByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    [HttpDelete]
    [ProducesResponseType(typeof(DeleteGameByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteGameById([FromQuery] DeleteGameByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<DeleteGameByIdCommand>(request);
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<DeleteGameByIdResponse>(result);
        return Ok(mappedResult);
    }
}