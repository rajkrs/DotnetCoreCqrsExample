using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raj.Infrastructure.FluentValidation
{
    public static class IMvcBuilderExtension
    {

        public static IMvcBuilder AddRajFluentValidation(this IMvcBuilder mvcBuilder, Type type)
        {
            mvcBuilder.AddFluentValidation(fv => {
                fv.RegisterValidatorsFromAssemblyContaining(type);
                fv.RunDefaultMvcValidationAfterFluentValidationExecutes = false;
                fv.ImplicitlyValidateChildProperties = true;
            });
            return mvcBuilder;
        }

    }
}
