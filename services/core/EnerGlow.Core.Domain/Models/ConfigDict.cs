using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace EnerGlow.Core.Domain.Models
{
    /// <summary>
    /// 字典配置实体
    /// </summary>

    [Table("config_dict")]
    public class ConfigDict : Entity<string>
    {
        ///<summary>
		///键主
		///</summary>
        public string? DictKey { get; set; }

        ///<summary>
		///键值
		///</summary>
        public string? DictValue { get; set; }

        ///<summary>
		///描述
		///</summary>
        public string? Description { get; set; }
    }
}
