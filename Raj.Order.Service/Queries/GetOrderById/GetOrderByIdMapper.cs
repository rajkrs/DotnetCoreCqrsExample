using AutoMapper;
using Raj.Infrastructure.Automapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raj.Order.Mediator.Queries.GetOrderById
{
    public class GetOrderByIdMapper : IMapperProfile
    {
        public GetOrderByIdMapper(Profile configuration)
        {
            configuration.CreateMap<Raj.Order.Ef.Order, OrderDetailViewModel>()
               .ForMember(oM => oM.OrderId, opt => opt.MapFrom(o => o.OrderId))
               .ReverseMap();
        }
    }
}
