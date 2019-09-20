using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Raj.Order.Mediator.Queries.GetOrderById;

namespace Raj.Order.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)





        {
            _mediator = mediator;
        }


        [HttpGet("{orderid}")]
        public async Task<OrderDetailViewModel> GetOrderDetailAsync([FromRoute] int orderid, CancellationToken ct)
        {
            return await _mediator.Send(new GetOrderByIdQuery {
                OrderId = orderid
            }, ct);
        }


        [HttpGet("flv")]
        public async Task<OrderDetailViewModel> GetOrderDetailAsync([FromQuery] GetOrderByIdQuery  getOrderByIdQuery, CancellationToken ct)
        {
            return await _mediator.Send(getOrderByIdQuery, ct);
        }

    }
}