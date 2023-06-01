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
public class AddressController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public AddressController(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }
    
    /// <summary>
    /// Get All Addresses
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("all")]
    [ProducesResponseType(typeof(GetAllAddressesResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllAddresses(CancellationToken cancellationToken)
    {
        var query = new GetAllAddressesQuery();
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<GetAllAddressesResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get Addresses By Country
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("get-by-country")]
    [ProducesResponseType(typeof(GetAddressesByCountryResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetAddressesByCountry([FromQuery] GetAddressesByCountryRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<GetAddressesByCountryQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<GetAddressesByCountryResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get Addresses By City
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("get-by-city")]
    [ProducesResponseType(typeof(GetAddressesByCityResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetAddressesByCity([FromQuery] GetAddressesByCityRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<GetAddressesByCityQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<GetAddressesByCityResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get Address By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("get-by-id")]
    [ProducesResponseType(typeof(GetAddressByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetAddressById([FromQuery] GetAddressByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<GetAddressByIdQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<GetAddressByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get User Of Address By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("user")]
    [ProducesResponseType(typeof(GetUserOfAddressByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetUserOfAddressById([FromQuery] GetUserOfAddressByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<GetUserOfAddressByIdQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<GetUserOfAddressByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Check Address Exists By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("check-exists")]
    [ProducesResponseType(typeof(CheckAddressExistsByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> CheckAddressExistsById([FromQuery] CheckAddressExistsByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<CheckAddressExistsByIdQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<CheckAddressExistsByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Create New Address
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost]
    [ProducesResponseType(typeof(CreateNewAddressResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> CreateNewAddress([FromBody] CreateNewAddressRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<CreateNewAddressCommand>(request);
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<CreateNewAddressResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Update Address By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPut]
    [ProducesResponseType(typeof(UpdateAddressByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> UpdateAddressById([FromBody] UpdateAddressByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<UpdateAddressByIdCommand>(request);
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<UpdateAddressByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Delete Address By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpDelete]
    [ProducesResponseType(typeof(DeleteAddressByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteAddressById([FromQuery] DeleteAddressByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<DeleteAddressByIdCommand>(request);
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<DeleteAddressByIdResponse>(result);
        return Ok(mappedResult);
    }
}