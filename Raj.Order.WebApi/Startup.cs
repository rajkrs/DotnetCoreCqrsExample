using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Raj.Order.Mediator.Commands.CreateOrder;
using Raj.Infrastructure.MediatR;
using Raj.Infrastructure.Automapper;
using Raj.Infrastructure.FluentValidation;
using Raj.Order.Ef;
using Raj.Infrastructure.MssqlDbContext;
using Raj.Infrastructure.Exception;
using Raj.Infrastructure.ApiBehavior;

namespace Raj.Order.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddRajMssqlDbContext(Configuration);
            services.AddRajMediatR(typeof(CreateOrderCommand));
            services.AddRajAutomapper(typeof(CreateOrderCommandMapper));

            services.AddControllers()
                        .AddRajFluentValidation(typeof(CreateOrderCommandValidator));

            services.AddRajApiBehaviorModelSateValidation();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, OrderContext orderContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRajGlobalException();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });








            OrderContextInitializer.Initialize(orderContext);
        }
    }
}
