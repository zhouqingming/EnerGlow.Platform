using EnerGlow.Core.Domain.Models;
using EnerGlow.Core.Domain.Repositorys;
using EnerGlow.Core.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace EnerGlow.Core.Infrastructure.Repositorys
{
    /// <summary>
    /// 实现ConfigDict仓储
    /// </summary>
    [Dependency(ServiceLifetime.Singleton)]
    public class ConfigDictRepository : EfCoreRepository<CoreContext, ConfigDict, string>, IConfigDictRepository
    {
        public CoreContext coreContext{ get; set; }
        public ConfigDictRepository(IDbContextProvider<CoreContext> dbContextProvider) : base(dbContextProvider)
        {
           
        }

        public async Task<List<ConfigDict>> GetListAll()
        {
          return await  coreContext.ConfigDicts.ToListAsync();
        }
    }
}
