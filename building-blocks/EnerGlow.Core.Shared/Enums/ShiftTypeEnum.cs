using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    public enum ShiftTypeEnum
    {
        /// <summary>
        /// 整天
        /// </summary>
        [Description("整天")]
        AllDayLong = 0,
        /// <summary>
        /// 早班
        /// </summary>
        [Description("早")]
        MorningShift = 1,
        /// <summary>
        /// 中班
        /// </summary>
        [Description("中")]
        MiddleShift = 2,
        /// <summary>
        /// 晚班
        /// </summary>
        [Description("晚")]
        NightShift = 3,
    }
}
