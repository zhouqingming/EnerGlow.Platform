using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 限值类型(1：上限 2：等值 3：下限)
    /// </summary>
    public enum LimitValueType
    {

        /// <summary>
        /// 上限
        /// </summary>
        [Description("上限")]
        UpperLimit = 1,

        /// <summary>
        /// 等值
        /// </summary>
        [Description("等值")]
        Equivalent = 2,

        /// <summary>
        /// 下限
        /// </summary>
        [Description("下限")]
        LowerLimit = 3,
    }
}
