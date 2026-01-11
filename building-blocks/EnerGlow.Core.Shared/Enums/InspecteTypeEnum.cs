using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 巡检类型 1日巡检 2月巡检 3年巡检
    /// </summary>
    public enum InspecteTypeEnum
    {
        /// <summary>
        /// 1日巡检
        /// </summary>
        [Description("日巡检")]
        DayInspecte = 1,
        /// <summary>
        /// 2月巡检
        /// </summary>
        [Description("月巡检")]
        MonthInspecte = 2,
        /// <summary>
        /// 3年巡检
        /// </summary>
        [Description("年巡检")]
        YearInspecte = 3

    }
}
