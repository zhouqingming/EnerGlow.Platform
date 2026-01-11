using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 月份枚举
    /// 0:全年
    /// 1:一月份
    /// 2:二月份
    /// ...
    /// 12:十二月份
    /// </summary>
    public enum MonthType
    {
        /// <summary>
        /// 全年
        /// </summary>
        [Description("全年")]
        EveryMonth = 0,

        /// <summary>
        /// 一月份
        /// </summary>
        [Description("一月份")]
        January = 1,

        /// <summary>
        /// 二月份
        /// </summary>
        [Description("二月份")]
        February = 2,

        /// <summary>
        /// 三月份
        /// </summary>
        [Description("三月份")]
        March = 3,

        /// <summary>
        /// 四月份
        /// </summary>
        [Description("四月份")]
        April = 4,

        /// <summary>
        /// 五月份
        /// </summary>
        [Description("五月份")]
        May = 5,

        /// <summary>
        /// 六月份
        /// </summary>
        [Description("六月份")]
        June = 6,

        /// <summary>
        /// 七月份
        /// </summary>
        [Description("七月份")]
        July = 7,

        /// <summary>
        /// 八月份
        /// </summary>
        [Description("八月份")]
        August = 8,

        /// <summary>
        /// 九月份
        /// </summary>
        [Description("九月份")]
        September = 9,

        /// <summary>
        /// 十月份
        /// </summary>
        [Description("十月份")]
        October = 10,

        /// <summary>
        /// 十一月份
        /// </summary>
        [Description("十一月份")]
        November = 11,

        /// <summary>
        /// 十二月份
        /// </summary>
        [Description("十二月份")]
        December = 12,
    }
}
