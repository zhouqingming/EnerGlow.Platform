using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace EnerGlow.PowerMonitor.Domain
{
    /// <summary>
    /// 领域Module
    /// </summary>
    [DependsOn(typeof(AbpDddDomainModule))]
    public class DomainModule:AbpModule
    {
        public override void ConfigureServices(
          ServiceConfigurationContext context)
        {

        }
    }
}
