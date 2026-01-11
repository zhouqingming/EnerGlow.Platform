using EnerGlow.Core.Domain;
using EnerGlow.Core.Infrastructure.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.MySQL;
using Volo.Abp.Modularity;

namespace EnerGlow.Core.Infrastructure
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
