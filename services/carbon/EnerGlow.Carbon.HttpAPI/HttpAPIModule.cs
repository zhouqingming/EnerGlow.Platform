using EnerGlow.Carbon.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace EnerGlow.Carbon.HttpAPI
{

    /// <summary>
    /// 领域HttpAPI
    /// </summary>
    [DependsOn(typeof(ApplicationModule),
               typeof(AbpAspNetCoreMvcModule)
        )]
    public class HttpAPIModule : AbpModule
    {
        public override void ConfigureServices(
            ServiceConfigurationContext context)
        {

        }
    }
}
