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
public class CategoryController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public CategoryController(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }
    
    /// <summary>
    /// Get All Categories
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("all")]
    [ProducesResponseType(typeof(GetAllCategoriesResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllCategories(CancellationToken cancellationToken)
    {
        var query = new GetAllCategoriesQuery();
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<GetAllCategoriesResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get Category By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("get-by-id")]
    [ProducesResponseType(typeof(GetCategoryByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetCategoryById([FromQuery] GetCategoryByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<GetCategoryByIdQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<GetCategoryByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get Category By Name
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("get-by-name")]
    [ProducesResponseType(typeof(GetCategoryByNameResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetCategoryByName([FromQuery] GetCategoryByNameRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<GetCategoryByNameQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<GetCategoryByNameResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get Games Of Category By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("games")]
    [ProducesResponseType(typeof(GetGamesOfCategoryByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetGamesOfCategoryById([FromQuery] GetGamesOfCategoryByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<GetGamesOfCategoryByIdQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<GetGamesOfCategoryByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Check Category Exists By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("check-exists")]
    [ProducesResponseType(typeof(CheckCategoryExistsByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> CheckCategoryExistsById([FromQuery] CheckCategoryExistsByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<CheckCategoryExistsByIdQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<CheckCategoryExistsByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Create New Category
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost]
    [ProducesResponseType(typeof(CreateNewCategoryResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> CreateNewCategory([FromBody] CreateNewCategoryRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<CreateNewCategoryCommand>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<CreateNewCategoryResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Update Category By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPut]
    [ProducesResponseType(typeof(UpdateCategoryByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> UpdateCategoryById([FromBody] UpdateCategoryByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<UpdateCategoryByIdCommand>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<UpdateCategoryByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Delete Category By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpDelete]
    [ProducesResponseType(typeof(DeleteCategoryByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteCategoryById([FromQuery] DeleteCategoryByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<DeleteCategoryByIdCommand>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<DeleteCategoryByIdResponse>(result);
        return Ok(mappedResult);
    }
}