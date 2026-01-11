using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 巡检/保养时间类型(0:周期 1:时间点)
    /// </summary>
    public enum WorkOrderTimeType
    {

        /// <summary>
        /// 周期
        /// </summary>
        [Description("周期")]
        Cycle = 0,

        /// <summary>
        /// 时间点
        /// </summary>
        [Description("时间点")]
        Point = 1

    }
}
