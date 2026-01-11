using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace EnerGlow.Core.Application.Dtos
{
    public class ConfigDictUpdateDto 
    {
        ///<summary>
        ///键主
        ///</summary>
        public string DictKey { get; set; }

        ///<summary>
		///键值
		///</summary>
        public string DictValue { get; set; }

        ///<summary>
		///描述
		///</summary>
        public string Description { get; set; }
    }
}
