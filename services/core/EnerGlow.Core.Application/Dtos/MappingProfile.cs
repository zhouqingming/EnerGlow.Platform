
using AutoMapper;
using EnerGlow.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Application.Dtos
{
    /// <summary>
    /// AutoMapper映射配置 - 定义DTO和实体之间的映射规则
    /// </summary>
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ConfigDict, ConfigDictGetPageResultDto>();

            CreateMap<ConfigDictGetPageResultDto, ConfigDict>();

            CreateMap<ConfigDictCreateDto, ConfigDict>();

            CreateMap<ConfigDictUpdateDto, ConfigDict>();

            CreateMap<ConfigDictDto, ConfigDict>();


        }
    }
}
