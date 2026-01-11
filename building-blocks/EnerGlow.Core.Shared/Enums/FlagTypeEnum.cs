using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlagTypeEnum
    {
        /// <summary>
        /// 未确认
        /// </summary>
        [Description("未确认")]
        No =0,

        /// <summary>
        /// 已确认
        /// </summary>
        [Description("已确认")]
        Yes =1,
    }
}
