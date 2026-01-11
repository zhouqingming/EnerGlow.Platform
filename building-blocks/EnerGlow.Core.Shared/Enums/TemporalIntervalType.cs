using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 时间类型(0：尖 1：峰 2：平 3：谷)
    /// </summary>
    public enum TemporalIntervalType
    {
        /// <summary>
        /// 尖
        /// </summary>
        [Description("尖")]
        Peak = 0,

        /// <summary>
        /// 峰
        /// </summary>
        [Description("峰")]
        High = 1,

        /// <summary>
        /// 平
        /// </summary>
        [Description("平")]
        Horizontal = 2,

        /// <summary>
        /// 谷
        /// </summary>
        [Description("谷")]
        Low = 3,
    }
}
