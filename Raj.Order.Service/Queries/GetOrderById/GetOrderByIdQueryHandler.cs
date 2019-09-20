using AutoMapper;
using MediatR;
using Raj.Order.Ef;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Raj.Order.Mediator.Queries.GetOrderById
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, OrderDetailViewModel>
    {

        private readonly OrderContext _orderContext;
        private readonly IMapper _mapper;
        public GetOrderByIdQueryHandler(OrderContext orderContext, IMapper mapper)
        {
            _orderContext = orderContext;
            _mapper = mapper;
        }

        public async Task<OrderDetailViewModel> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        
        {
            var order = await _orderContext.Orders.FindAsync(request.OrderId);
            return _mapper.Map<OrderDetailViewModel>(order);
        }
    }
}
