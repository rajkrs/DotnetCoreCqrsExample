using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raj.Order.Mediator.Queries.GetOrderById
{

    public class GetOrderByIdQueryValidator : AbstractValidator<GetOrderByIdQuery>
    {
        public GetOrderByIdQueryValidator()
        {
            RuleFor(x => x.OrderId).NotNull().GreaterThan(0).LessThan(50);
        }
    }


}
