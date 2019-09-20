using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Raj.Order.Ef;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raj.Infrastructure.MssqlDbContext
{
    public static class IServiceCollectionExtension
    {

        public static IServiceCollection AddRajMssqlDbContext(this IServiceCollection services, IConfiguration configuration )
        {
            var useInMemoryDatabase = configuration.GetSection("Settings").GetValue<bool>("UseInMemoryDatabase");

            services.AddDbContext<OrderContext, OrderContext>(options =>
            {
                if (useInMemoryDatabase)
                {
                    options.UseInMemoryDatabase("OrderContext");
                }
                else
                {
                    options.UseSqlServer(configuration.GetConnectionString("OrderContext"));
                }
            });

            return services;
        }

    }
}
