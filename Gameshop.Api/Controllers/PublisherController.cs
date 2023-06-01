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
public class PublisherController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public PublisherController(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }

    /// <summary>
    /// Get All Publishers
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("all")]
    [ProducesResponseType(typeof(GetAllPublishersResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllPublishers(CancellationToken cancellationToken)
    {
        var query = new GetAllPublishersQuery();
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<GetAllPublishersResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get Publisher By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("get-by-id")]
    [ProducesResponseType(typeof(GetPublisherByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetPublisherById([FromQuery] GetPublisherByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<GetPublisherByIdQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<GetPublisherByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get Publisher By Name
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("get-by-name")]
    [ProducesResponseType(typeof(GetPublisherByNameResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetPublisherByName([FromQuery] GetPublisherByNameRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<GetPublisherByNameQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<GetPublisherByNameResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get Games Of Publisher By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("get-games")]
    [ProducesResponseType(typeof(GetGamesOfPublisherByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetGamesOfPublisherById([FromQuery] GetGamesOfPublisherByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<GetGamesOfPublisherByIdQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<GetGamesOfPublisherByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Check Publisher Exists By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("check-exists")]
    [ProducesResponseType(typeof(CheckPublisherExistsByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> CheckPublisherExistsById([FromQuery] CheckPublisherExistsByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<CheckPublisherExistsByIdQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<CheckPublisherExistsByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Create New Publisher
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost]
    [ProducesResponseType(typeof(CreateNewPublisherResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> CreateNewPublisher([FromBody] CreateNewPublisherRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<CreateNewPublisherCommand>(request);
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<CreateNewPublisherResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Update Publisher By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPut]
    [ProducesResponseType(typeof(UpdatePublisherByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> UpdatePublisherById([FromBody] UpdatePublisherByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<UpdatePublisherByIdCommand>(request);
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<UpdatePublisherByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Delete Publisher By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpDelete]
    [ProducesResponseType(typeof(DeletePublisherByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeletePublisherById([FromQuery] DeletePublisherByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<DeletePublisherByIdCommand>(request);
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<DeletePublisherByIdResponse>(result);
        return Ok(mappedResult);
    }
}