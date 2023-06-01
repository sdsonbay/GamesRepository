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
public class OrderController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public OrderController(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }

    /// <summary>
    /// Get All Orders
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("all")]
    [ProducesResponseType(typeof(GetAllOrdersResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllOrders(CancellationToken cancellationToken)
    {
        var query = new GetAllOrdersQuery();
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<GetAllOrdersResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get Orders By Order Status
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("get-by-status")]
    [ProducesResponseType(typeof(GetOrdersByOrderStatusResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetOrdersByOrderStatus([FromQuery] GetOrdersByOrderStatusRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<GetOrdersByOrderStatusQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<GetOrdersByOrderStatusResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get Order By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("get-by-id")]
    [ProducesResponseType(typeof(GetOrderByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetOrderById([FromQuery] GetOrderByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<GetOrderByIdQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<GetOrderByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get User Of Order By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("user")]
    [ProducesResponseType(typeof(GetUserOfOrderByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetUserOfOrderById([FromQuery] GetUserOfOrderByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<GetUserOfOrderByIdQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<GetUserOfOrderByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Get Game Of Order By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("game")]
    [ProducesResponseType(typeof(GetGameOfOrderByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetGameOfOrderById([FromQuery] GetGameOfOrderByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<GetGameOfOrderByIdQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        if (result is null)
        {
            return NotFound();
        }
        var mappedResult = _mapper.Map<GetGameOfOrderByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Check Order Exists By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("check-exists")]
    [ProducesResponseType(typeof(CheckOrderExistsByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> CheckOrderExistsById([FromQuery] CheckOrderExistsByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<CheckOrderExistsByIdQuery>(request);
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<CheckOrderExistsByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Create New Order
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost]
    [ProducesResponseType(typeof(CreateNewOrderResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> CreateNewOrder([FromBody] CreateNewOrderRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<CreateNewOrderCommand>(request);
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<CreateNewOrderResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Update Order By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPut]
    [ProducesResponseType(typeof(UpdateOrderByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> UpdateOrderById([FromBody] UpdateOrderByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<UpdateOrderByIdCommand>(request);
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<UpdateOrderByIdResponse>(result);
        return Ok(mappedResult);
    }
    
    /// <summary>
    /// Delete Order By Id
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpDelete]
    [ProducesResponseType(typeof(DeleteOrderByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteOrderById([FromQuery] DeleteOrderByIdRequest request, CancellationToken cancellationToken)
    {
        var query = _mapper.Map<DeleteOrderByIdCommand>(request);
        var result = await _mediator.Send(query, cancellationToken);
        var mappedResult = _mapper.Map<DeleteOrderByIdResponse>(result);
        return Ok(mappedResult);
    }
}