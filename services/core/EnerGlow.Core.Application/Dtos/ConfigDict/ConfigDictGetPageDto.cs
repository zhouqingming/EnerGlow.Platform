using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace EnerGlow.Core.Application.Dtos
{
    public class ConfigDictGetPageDto : PagedAndSortedResultRequestDto
    {
        ///<summary>
        ///键主
        ///</summary>
        public string? DictKey { get; set; } = string.Empty;

        ///<summary>
		///键值
		///</summary>
        public string? DictValue { get; set; } = string.Empty;
    }
}
