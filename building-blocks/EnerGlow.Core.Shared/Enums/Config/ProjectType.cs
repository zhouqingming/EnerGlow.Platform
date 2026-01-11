using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 项目类型
    /// 1：工业企业  2：商业大楼
    /// </summary>
    public enum ProjectType
    {
        /// <summary>
        /// 工业企业
        /// </summary>
        [Description("工业企业")]
        Industrial = 1,

        /// <summary>
        /// 商业大楼
        /// </summary>
        [Description("商业大楼")]
        Business = 2,

        /// <summary>
        /// 轨道交通
        /// </summary>
        [Description("轨道交通")]
        RailTransit = 3,
    }
}
