using Gameshop.Domain.Args;
using Gameshop.Domain.Dtos;
using Gameshop.Domain.Ports.Models;
using MediatR;

namespace Gameshop.Application.Queries;

public class GetPublisherByNameQuery : GetPublisherByNameArgs, IRequest<GetPublisherByNameOutput>
{
    
}