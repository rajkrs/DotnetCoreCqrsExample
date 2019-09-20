using AutoMapper;
using MediatR;
using Raj.Infrastructure.Automapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raj.Order.Mediator.Commands.CreateOrder
{
    public class CreateOrderCommandMapper : IMapperProfile
    {
        public CreateOrderCommandMapper(Profile configuration)
        {
            configuration.CreateMap<Raj.Order.Ef.Order, CreateOrderCommand>()
               .ForMember(oM => oM.OrderId, opt => opt.MapFrom(o => o.OrderId))
               .ReverseMap();
        }
    }


}
