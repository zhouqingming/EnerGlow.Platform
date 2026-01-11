using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 值类型(1：数值 2：百分比)
    /// </summary>
    public enum ValueType
    {

        /// <summary>
        /// 数值
        /// </summary>
        [Description("数值")]
        NumericalValue = 1,

        /// <summary>
        /// 百分比
        /// </summary>
        [Description("百分比")]
        PercentValue = 2,
    }
}
