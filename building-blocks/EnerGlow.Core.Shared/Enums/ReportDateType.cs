using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 报表时间类型枚举
    /// </summary>
    public enum ReportDateType
    {
        /// <summary>
        /// 自由时间
        /// </summary>
        [Description("自由时间")]
        Free = 0,

        /// <summary>
        /// 固定时间间隔
        /// </summary>
        [Description("固定时间间隔")]
        FixedInterval =1,

        /// <summary>
        /// 实时时间
        /// </summary>
        [Description("实时时间")]
        RealTime =2,
    }
}
