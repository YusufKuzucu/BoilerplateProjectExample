using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MicroWebExample.Application.Interfaces;
using MicroWebExample.Application.Interfaces.Repositories;
using MicroWebExample.Application.Mapping;
using MicroWebExample.Persistence.Context;
using MicroWebExample.Persistence.Repositories;
using MicroWebExample.Persistence.Repositories.AppServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroWebExample.Persistence
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration = null)
        {

            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration?.GetConnectionString("SQLConnection")));

            services.AddTransient(typeof(IBaseRepository<,>), typeof(BaseRepository<,>));
            services.AddTransient<IBlogService, BlogRepository>();
            services.AddTransient<IBlogAppService, BlogAppService>();

            services.AddTransient<ISliderService, SliderRepository>();
            services.AddTransient<ISliderAppService, SliderAppService>();


            services.AddTransient<IContactService, ContactRepository>();
            services.AddTransient<IContactAppService, ContactAppService>();
            return services;
        }
    }
}
