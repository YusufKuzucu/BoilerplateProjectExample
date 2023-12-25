using Microsoft.Extensions.DependencyInjection;
using MicroWebExample.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MicroWebExample.Application
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddApplication<GeneralMappingModule>();
            return services;
        }
    }
}
