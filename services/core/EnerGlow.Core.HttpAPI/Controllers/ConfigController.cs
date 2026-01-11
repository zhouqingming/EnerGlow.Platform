using EnerGlow.Core.Application.Dtos;
using EnerGlow.Core.Application.Services;
using EnerGlow.Core.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;

namespace EnerGlow.Core.HttpAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConfigController : AbpController
    {
        public IConfigDictService _configDictService { get; set; }

        [HttpGet("GetConfig")]
        public async Task<PagedResultDto<ConfigDictGetPageResultDto>> GetConfig([FromQuery]ConfigDictGetPageDto configDictGet)
        {
            return await _configDictService.GetListAsync(configDictGet);
        }

        [HttpGet("GetListAll")]
        public async Task<List<ConfigDict>> GetListAll()
        {
           return await  _configDictService.GetListAll();
        }
    }
}
