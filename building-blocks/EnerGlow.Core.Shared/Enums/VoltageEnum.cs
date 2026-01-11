using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 电压类型
    /// </summary>
    public enum VoltageEnum
    {
        /// <summary>
        /// 不区分
        /// </summary>
        [Description("不区分")]
        NoPressure = 0,
        /// <summary>
        /// 高压
        /// </summary>
        [Description("高压")]
        HighPressure = 1,
        /// <summary>
        /// 低压
        /// </summary>
        [Description("低压")]
        LowPressure = 2,
        /// <summary>
        /// 变压
        /// </summary>
        [Description("变压")]
        ChangePressure = 3
    }
}
