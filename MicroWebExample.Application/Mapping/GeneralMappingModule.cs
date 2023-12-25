using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace MicroWebExample.Application.Mapping
{
    [DependsOn(typeof(AbpAutoMapperModule))]
    public class GeneralMappingModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<GeneralMappingModule>();
            });
            context.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }



    }
}
