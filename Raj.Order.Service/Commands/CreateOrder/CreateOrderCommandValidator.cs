using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raj.Order.Mediator.Commands.CreateOrder
{
    public class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
    {
        public CreateOrderCommandValidator()
        {
            RuleFor(x => x.OrderId).NotNull().GreaterThan(0).LessThan(50);
        }
    }
}
