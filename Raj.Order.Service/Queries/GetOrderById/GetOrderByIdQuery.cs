using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raj.Order.Mediator.Queries.GetOrderById
{
    public class GetOrderByIdQuery : IRequest<OrderDetailViewModel>
    {
        public int OrderId { get; set; }
    }
}
