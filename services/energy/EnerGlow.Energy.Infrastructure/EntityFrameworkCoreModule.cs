using EnerGlow.Energy.Domain;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.MySQL;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;
using EnerGlow.Energy.Infrastructure.Contexts;

namespace EnerGlow.Energy.Infrastructure
{
    /// <summary>
    /// 领域EntityFrameworkCore
    /// </summary>
    [DependsOn(typeof(DomainModule),
               typeof(AbpEntityFrameworkCoreModule),
               typeof(AbpEntityFrameworkCoreMySQLModule)
        )]
    public class EntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(
            ServiceConfigurationContext context)
        {
            

            // 1、注册ProjectContext
            context.Services.AddAbpDbContext<CoreContext>();

            Configure<AbpDbContextOptions>(options => {
                    options.UseMySQL();
            });
        }
    }
}
