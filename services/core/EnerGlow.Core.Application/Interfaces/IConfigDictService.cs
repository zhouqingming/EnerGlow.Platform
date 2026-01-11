using EnerGlow.Core.Application.Dtos;
using EnerGlow.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace EnerGlow.Core.Application.Services
{
    public interface IConfigDictService:ICrudAppService<ConfigDictDto, ConfigDictGetPageResultDto, string, ConfigDictGetPageDto,ConfigDictCreateDto,ConfigDictUpdateDto>
    {
         Task<List<ConfigDict>> GetListAll();
    }
}
