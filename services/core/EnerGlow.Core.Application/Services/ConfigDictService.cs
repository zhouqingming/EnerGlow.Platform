using EnerGlow.Core.Application.Dtos;
using EnerGlow.Core.Domain.Models;
using EnerGlow.Core.Domain.Repositorys;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace EnerGlow.Core.Application.Services
{

    [Dependency(ServiceLifetime.Singleton)]
    public class ConfigDictService : CrudAppService<ConfigDict,ConfigDictDto, ConfigDictGetPageResultDto, string,
        ConfigDictGetPageDto, ConfigDictCreateDto, ConfigDictUpdateDto>, IConfigDictService
    {
        public IConfigDictRepository dictRepository { get; set; }
        public ConfigDictService(IConfigDictRepository repository) : base(repository)
        {
            
        }

        public async Task<List<ConfigDict>> GetListAll()
        {
           return await dictRepository.GetListAll();
        }
    }
}
