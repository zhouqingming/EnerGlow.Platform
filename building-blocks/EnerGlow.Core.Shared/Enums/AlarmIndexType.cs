using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 指标告警类型（1：日能耗 2:月能耗 3:年能耗）
    /// 此处加多一个特性来标志调用的方法名
    /// </summary>
    public enum AlarmIndexType
    {

        /// <summary>
        /// 日能耗
        /// </summary>
        [Description("日能耗")]
        DayConsumption = 1,

        /// <summary>
        /// 月能耗
        /// </summary>
        [Description("月能耗")]
        MonthConsumption = 2,

        /// <summary>
        /// 年能耗
        /// </summary>
        [Description("年能耗")]
        YearConsumption = 3

    }
}
