using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 数据展示看板
    /// </summary>
    public enum DataDisplayModuleType
    {
        /// <summary>
        /// 能耗汇总
        /// </summary>
        [Description("能耗汇总")]
        EnergySummary = 0,

        /// <summary>
        /// 本日每小时能耗
        /// </summary>
        [Description("本日每小时能耗")]
        TodayHourEp = 1,

        /// <summary>
        /// 昨日每小时能耗
        /// </summary>
        [Description("昨日每小时能耗")]
        YesterdayHourEp = 2,

        /// <summary>
        /// 本周每天能耗
        /// </summary>
        [Description("本周每天能耗")]
        ThisWeekDayEp = 3,

        /// <summary>
        /// 上周每天能耗
        /// </summary>
        [Description("上周每天能耗")]
        LastWeekDayEp = 4,

        /// <summary>
        /// 本月每天能耗
        /// </summary>
        [Description("本月每天能耗")]
        ThisMonthDayEp = 5,

        /// <summary>
        /// 上月每天能耗
        /// </summary>
        [Description("上月每天能耗")]
        LastMonthDayEp = 6,

        /// <summary>
        /// 本年每月能耗
        /// </summary>
        [Description("本年每月能耗")]
        ThisYearMonthEp = 7,

        /// <summary>
        /// 去年每月能耗
        /// </summary>
        [Description("去年每月能耗")]
        LastYearMonthEp = 8,

        /// <summary>
        /// 本日每小时电流
        /// </summary>
        [Description("本日每小时电流")]
        TodayHourI = 9,

        /// <summary>
        /// 本日每小时电压
        /// </summary>
        [Description("本日每小时电压")]
        TodayHourU = 10,

        /// <summary>
        /// 本日每小时功率因数
        /// </summary>
        [Description("本日每小时功率因数")]
        TodayHourPF = 11,

        /// <summary>
        /// 本月能耗与KPI计划能耗
        /// </summary>
        [Description("本月能耗与KPI计划能耗")]
        ThisMonthEpWithKpi = 12,

        /// <summary>
        /// 上月能耗与KPI计划能耗
        /// </summary>
        [Description("上月能耗与KPI计划能耗")]
        LastMonthEpWithKpi = 13,

        /// <summary>
        /// 本日能耗与产能
        /// </summary>
        [Description("本日能耗与产能")]
        TodayEpWithCapacity = 14,

        /// <summary>
        /// 昨日能耗与产能
        /// </summary>
        [Description("昨日能耗与产能")]
        YesterdayEpWithCapacity = 15,

        /// <summary>
        /// 本月能耗与产能
        /// </summary>
        [Description("本月能耗与产能")]
        ThisMonthEpWithCapacity = 16,

        /// <summary>
        /// 上月能耗与产能
        /// </summary>
        [Description("上月能耗与产能")]
        LastMonthEpWithCapacity = 17,

        /// <summary>
        /// 设备本日能耗对比(包括子节点)
        /// </summary>
        [Description("设备本日能耗对比")]
        TodayDeviceEpComparison = 18,

        /// <summary>
        /// 设备昨日能耗对比(包括子节点)
        /// </summary>
        [Description("设备昨日能耗对比")]
        YesterdayDeviceEpComparison = 19,

        /// <summary>
        /// 设备本周能耗对比(包括子节点)
        /// </summary>
        [Description("设备本周能耗对比")]
        ThisWeekDeviceEpComparison = 20,

        /// <summary>
        /// 设备上周能耗对比(包括子节点)
        /// </summary>
        [Description("设备上周能耗对比")]
        LastWeekDeviceEpComparison = 21,

        /// <summary>
        /// 设备本月能耗对比(包括子节点)
        /// </summary>
        [Description("设备本月能耗对比")]
        ThisMonthDeviceEpComparison = 22,

        /// <summary>
        /// 设备上月能耗对比(包括子节点)
        /// </summary>
        [Description("设备上月能耗对比")]
        LastMonthDeviceEpComparison = 23,

        /// <summary>
        /// 设备本年能耗对比(包括子节点)
        /// </summary>
        [Description("设备本年能耗对比")]
        ThisYearDeviceEpComparison = 24,

        /// <summary>
        /// 设备上年能耗对比(包括子节点)
        /// </summary>
        [Description("设备上年能耗对比")]
        LastYearDeviceEpComparison = 25,

        /// <summary>
        /// 今日峰平谷能耗统计
        /// </summary>
        [Description("今日峰平谷尖能耗")]
        TodayPeakAndValleyEpData = 26,

        /// <summary>
        /// 昨日峰平谷尖能耗统计
        /// </summary>
        [Description("昨日峰平谷尖能耗")]
        YesterdayPeakAndValleyEpData = 27,

        /// <summary>
        /// 获取区域节点下的实时数据(包括子节点)
        /// </summary>
        [Description("区域节点下实时数据")]
        RealData = 28,

        /// <summary>
        /// 日分类分项
        /// </summary>
        [Description("日分类分项")]
        DayEneProportion =29,

        /// <summary>
        /// 上月峰平谷尖能耗
        /// </summary>
        [Description("上月峰平谷尖能耗")]
        LastMonthPeakAndVall =30,

        /// <summary>
        /// 本月峰平谷尖能耗
        /// </summary>
        [Description("本月峰平谷尖能耗")]
        ThisMonthPeakAndVall =31,

        /// <summary>
        /// 能耗对标
        /// </summary>
        [Description("能耗对标")]
        EnergyComparison =32,

        /// <summary>
        /// 电耗预测
        /// </summary>
        [Description("电耗预测")]
        MonthKwhForecast =33,

        /// <summary>
        /// 能耗设备排比
        /// </summary>
        [Description("能耗设备排比")]
        StatisticsDevPar =34,

        /// <summary>
        /// 电能质量
        /// </summary>
        [Description("电能质量")]
        PowerQuality =35,
    }
}
