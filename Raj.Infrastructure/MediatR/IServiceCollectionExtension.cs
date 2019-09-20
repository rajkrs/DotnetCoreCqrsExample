using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Raj.Infrastructure.FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raj.Infrastructure.MediatR
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddRajMediatR(this IServiceCollection services, Type type)
        {
            services.AddMediatR(type.Assembly);
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));
            return services;
        }
    }
}
