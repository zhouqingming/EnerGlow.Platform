using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace EnerGlow.PowerMonitor.Infrastructure.Contexts
{
    /// <summary>
    /// 1、自定义上下文【全局上下文】
    /// </summary>
    [ConnectionStringName("Default")]
    public class CoreContext : AbpDbContext<CoreContext>
    {
        public CoreContext(DbContextOptions<CoreContext> options) : base(options)
        {
        }
    }
}
