using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raj.Order.Mediator.Commands.CreateOrder
{
    public class CreateOrderCommand : IRequest
    {
        public int OrderId { get; set; }
    }
}
