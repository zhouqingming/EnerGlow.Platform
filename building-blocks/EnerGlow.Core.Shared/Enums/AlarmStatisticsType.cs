using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 报警统计类型（1：异常事件 2:设备）
    /// </summary>
    public enum AlarmStatisticsType
    {

        /// <summary>
        /// 异常事件
        /// </summary>
        [Description("异常事件")]
        Event = 1,

        /// <summary>
        /// 设备
        /// </summary>
        [Description("设备")]
        Device = 2

    }
}
