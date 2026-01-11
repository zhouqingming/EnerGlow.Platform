using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 电度小时表统计类型（0：小时  1：15分钟）
    /// </summary>
    public enum StatisticsHourType
    {

        /// <summary>
        /// 小时
        /// </summary>
        [Description("小时")]
        Hour = 0,

        /// <summary>
        /// 15分钟
        /// </summary>
        [Description("15分钟")]
        Minute15 = 1,

        /// <summary>
        /// 天
        /// </summary>
        [Description("天")]
        Day = 2,

        /// <summary>
        /// 月
        /// </summary>
        [Description("月")]
        Month = 3,

        /// <summary>
        /// 年
        /// </summary>
        [Description("年")]
        Year = 4
    }
}
