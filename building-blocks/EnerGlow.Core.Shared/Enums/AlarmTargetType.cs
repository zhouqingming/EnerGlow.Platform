using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 告警对象类型（1：设备 2：区域）
    /// </summary>
    public enum AlarmTargetType
    {

        /// <summary>
        /// 设备
        /// </summary>
        [Description("设备")]
        Device = 1,

        /// <summary>
        /// 区域
        /// </summary>
        [Description("区域")]
        Area = 2

    }
}
