using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Raj.Infrastructure.Automapper
{
    public static class IServiceCollectionExtension
    {

        public static IServiceCollection AddRajAutomapper(this IServiceCollection services, Type type)
        {
            services.AddAutoMapper(new Assembly[] { typeof(AutoMapperProfile).GetTypeInfo().Assembly, type.Assembly });
            return services;
        }

    }
}
