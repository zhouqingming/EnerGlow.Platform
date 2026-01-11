using EnerGlow.Energy.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace EnerGlow.Energy.Application
{
    /// <summary>
    /// 领域Application
    /// </summary>
    [DependsOn(typeof(DomainModule),
               typeof(AbpAutoMapperModule)
     )]
    public class ApplicationModule : AbpModule
    {
        public override void ConfigureServices(
            ServiceConfigurationContext context)
        {

            // 3、配置AutoMap
            Configure<AbpAutoMapperOptions>(options => {
                options.AddMaps<ApplicationModule>();
            });

        }
    }
}
