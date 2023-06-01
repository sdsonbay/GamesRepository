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
public class CreditCardController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public CreditCardController(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }
    
    /// <summary>
    /// Get All Credit Cards
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("all")]
    [ProducesResponseType(typeof(GetAllCreditCardsResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllCreditCards(CancellationToken cancellationToken)
    {
        var query = new GetAllCreditCardsQuery();
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<GetAllCreditCardsResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get Credit Card By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("get-by-id")]
    [ProducesResponseType(typeof(GetCreditCardByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetCreditCardById([FromQuery] GetCreditCardByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<GetCreditCardByIdQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<GetCreditCardByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get User Of Credit Card By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("user")]
    [ProducesResponseType(typeof(GetUserOfCreditCardByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetUserOfCreditCardById([FromQuery] GetUserOfCreditCardByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<GetUserOfCreditCardByIdQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<GetUserOfCreditCardByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Check Credit Card Exists By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("check-exists")]
    [ProducesResponseType(typeof(CheckCreditCardExistsByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> CheckCreditCardExistsById([FromQuery] CheckCreditCardExistsByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<CheckCreditCardExistsByIdQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<CheckCreditCardExistsByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Create New Credit Card
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost]
    [ProducesResponseType(typeof(CreateNewCreditCardResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> CreateNewCreditCard([FromBody] CreateNewCreditCardRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<CreateNewCreditCardCommand>(request);
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<CreateNewCreditCardResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Update Credit Card By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPut]
    [ProducesResponseType(typeof(UpdateCreditCardByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> UpdateCreditCardById([FromBody] UpdateCreditCardByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<UpdateCreditCardByIdCommand>(request);
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<UpdateCreditCardByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Delete Credit Card By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpDelete]
    [ProducesResponseType(typeof(DeleteCreditCardByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteCreditCardById([FromQuery] DeleteCreditCardByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<DeleteCreditCardByIdCommand>(request);
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<DeleteCreditCardByIdResponse>(result);
        return Ok(mappedResult);
    }
}