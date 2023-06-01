using AutoMapper;
using Gameshop.Api.Models.Requests;
using Gameshop.Api.Models.Responses;
using Gameshop.Application.Commands;
using Gameshop.Application.Queries;
using Gameshop.Domain.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Gameshop.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public UserController(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }

    /// <summary>
    /// Get All Users
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("all")]
    [ProducesResponseType(typeof(GetAllUsersResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllUsers(CancellationToken cancellationToken = default)
    {
        var query = new GetAllUsersQuery();
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<GetAllUsersResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get User By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("get-by-id")]
    [ProducesResponseType(typeof(GetUserByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetUserById([FromQuery] GetUserByIdRequest request, CancellationToken cancellationToken = default)
    {
        var query = _mapper.Map<GetUserByIdQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result == null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<GetUserByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get User By Username
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("get-by-username")]
    [ProducesResponseType(typeof(GetUserByUsernameResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetUserByUsername([FromQuery] GetUserByUsernameRequest request, CancellationToken cancellationToken = default)
    {
        var query = _mapper.Map<GetUserByUsernameQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result == null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<GetUserByUsernameResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get User By Email
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("get-by-email")]
    [ProducesResponseType(typeof(GetUserByEmailResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetUserByEmail([FromQuery] GetUserByEmailRequest request, CancellationToken cancellationToken = default)
    {
        var query = _mapper.Map<GetUserByEmailQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result == null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<GetUserByEmailResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get Users By First Name
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("get-by-first-name")]
    [ProducesResponseType(typeof(GetUserByFirstNameResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetUsersByFirstName([FromQuery] GetUserByFirstNameRequest request, CancellationToken cancellationToken = default)
    {
        var query = _mapper.Map<GetUserByFirstNameQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<GetUserByFirstNameResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get Users By Last Name
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("get-by-last-name")]
    [ProducesResponseType(typeof(GetUserByLastNameResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetUsersByLastName([FromQuery] GetUserByLastNameRequest request, CancellationToken cancellationToken = default)
    {
        var query = _mapper.Map<GetUserByLastNameQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<GetUserByLastNameResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get Addresses Of User By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("addresses")]
    [ProducesResponseType(typeof(GetAddressesOfUserByIdResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAddressesOfUserById([FromQuery] GetAddressesOfUserByIdRequest request, CancellationToken cancellationToken = default)
    {
        var query = _mapper.Map<GetAddressesOfUserByIdQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<GetAddressesOfUserByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get Credit Cards Of User By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("credit-cards")]
    [ProducesResponseType(typeof(GetCreditCardsOfUserByIdResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetCreditCardsOfUserById([FromQuery] GetCreditCardsOfUserByIdRequest request, CancellationToken cancellationToken = default)
    {
        var query = _mapper.Map<GetCreditCardsOfUserByIdQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<GetCreditCardsOfUserByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get Orders Of User By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("orders")]
    [ProducesResponseType(typeof(GetOrdersOfUserByIdResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetOrdersOfUserById([FromQuery] GetOrdersOfUserByIdRequest request, CancellationToken cancellationToken = default)
    {
        var query = _mapper.Map<GetOrdersOfUserByIdQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<GetOrdersOfUserByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get Games Of User By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("games")]
    [ProducesResponseType(typeof(GetGamesOfUserByIdResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetGamesOfUserById([FromQuery] GetGamesOfUserByIdRequest request, CancellationToken cancellationToken = default)
    {
        var query = _mapper.Map<GetGamesOfUserByIdQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<GetGamesOfUserByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Check User Exists By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("check-exists")]
    [ProducesResponseType(typeof(CheckUserExistsByIdResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> CheckUserExistsById([FromQuery] CheckUserExistsByIdRequest request, CancellationToken cancellationToken = default)
    {
        var query = _mapper.Map<CheckUserExistsByIdQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<CheckUserExistsByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Create New User
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost]
    [ProducesResponseType(typeof(CreateNewUserResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> CreateNewUser([FromBody] CreateNewUserRequest request, CancellationToken cancellationToken = default)
    {
        var command = _mapper.Map<CreateNewUserCommand>(request);
        var result = await _mediator.Send(command, cancellationToken);
        var mappedResult = _mapper.Map<CreateNewUserResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Update User By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="user"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPut]
    [ProducesResponseType(typeof(UpdateUserByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateUserById([FromBody] UpdateUserByIdRequest request, CancellationToken cancellationToken = default)
    {
        var command = _mapper.Map<UpdateUserByIdCommand>(request);
        var result = await _mediator.Send(command, cancellationToken);
        var mappedResult = _mapper.Map<UpdateUserByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Delete User By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpDelete]
    [ProducesResponseType(typeof(DeleteUserByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> DeleteUserById([FromQuery] DeleteUserByIdRequest request, CancellationToken cancellationToken = default)
    {
        var command = _mapper.Map<DeleteUserByIdCommand>(request);
        var result = await _mediator.Send(command, cancellationToken);
        var mappedResult = _mapper.Map<DeleteUserByIdResponse>(result);
        return Ok(mappedResult);
    }
}