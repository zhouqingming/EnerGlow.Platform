using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 自定义月报表详情类型（0：列头  1：区域  2：能源种类  3：统计）
    /// </summary>
    public enum CustomMonthReportDetailsType
    {

        /// <summary>
        /// 列头
        /// </summary>
        [Description("列头")]
        ColumnHeader = 0,

        /// <summary>
        /// 区域
        /// </summary>
        [Description("区域")]
        Area = 1,

        /// <summary>
        /// 能源种类
        /// </summary>
        [Description("能源种类")]
        Energy = 2,

        /// <summary>
        /// 统计
        /// </summary>
        [Description("统计")]
        Statistics = 3

    }

    /// <summary>
    /// 自定义月报表列头类型
    /// </summary>
    public enum CustomMonthReportColumnHeaderType
    {

        /// <summary>
        /// 月度能耗
        /// </summary>
        [Description("月度能耗")]
        Consumption = 0,

        /// <summary>
        /// 同比能耗
        /// </summary>
        [Description("同比能耗")]
        LastYearConsumption = 1,

        /// <summary>
        /// 环比能耗
        /// </summary>
        [Description("环比能耗")]
        LastMonthConsumption = 2,

        /// <summary>
        /// 月度单耗
        /// </summary>
        [Description("月度单耗")]
        UnitConsumption = 3,

        /// <summary>
        /// 同比单耗
        /// </summary>
        [Description("同比单耗")]
        LastYearUnitConsumption = 4,

        /// <summary>
        /// 环比单耗 
        /// </summary>
        [Description("环比单耗 ")]
        LastMonthUnitConsumption = 5,

        /// <summary>
        /// 月度费用
        /// </summary>
        [Description("月度费用")]
        Cost = 6,

        /// <summary>
        /// 同比费用
        /// </summary>
        [Description("同比费用")]
        LastYearCost = 7,

        /// <summary>
        /// 环比费用
        /// </summary>
        [Description("环比费用")]
        LastMonthCost = 8,

        /// <summary>
        /// 月度产能
        /// </summary>
        [Description("月度产能")]
        Capacity = 9,

        /// <summary>
        /// 同比产能
        /// </summary>
        [Description("同比产能")]
        LastYearCapacity = 10,

        /// <summary>
        /// 环比产能
        /// </summary>
        [Description("环比产能")]
        LastMonthCapacity = 11,

        /// <summary>
        /// 月度预算用能
        /// </summary>
        [Description("月度预算用能")]
        PlanConsumption = 12,

        /// <summary>
        /// 月度预算单耗
        /// </summary>
        [Description("月度预算单耗")]
        PlanUnitConsumption = 13,

        /// <summary>
        /// 月度日均用能
        /// </summary>
        [Description("月度日均用能")]
        DailyConsumption = 14,

        /// <summary>
        /// 环比日均电能
        /// </summary>
        [Description("环比日均电能")]
        LastMonthDailyConsumption = 15,

        /// <summary>
        /// 同比日均电能
        /// </summary>
        [Description("同比日均电能")]
        LastYearDailyConsumption = 16,

        /// <summary>
        /// 用能偏差
        /// </summary>
        [Description("用能偏差")]
        ConsumptionDeviation = 17,

        /// <summary>
        /// 环比单耗增量 
        /// </summary>
        [Description("环比单耗增量 ")]
        LastMonthUnitConsumptionIncrement = 18,

        /// <summary>
        /// 环比单耗差异率
        /// </summary>
        [Description("环比单耗差异率")]
        LastMonthUnitConsumptionDiffRate = 19

    }

    /// <summary>
    /// 自定义月报表统计类型（0：平均值  1：合计  2：最大值  3：最小值）
    /// </summary>
    public enum CustomMonthReportStatisticsType
    {
        /// <summary>
        /// 平均值
        /// </summary>
        [Description("平均值")]
        Average = 0,

        /// <summary>
        /// 合计
        /// </summary>
        [Description("合计")]
        Total = 1,

        /// <summary>
        /// 最大值
        /// </summary>
        [Description("最大值")]
        Max = 2,

        /// <summary>
        /// 最小值
        /// </summary>
        [Description("最小值")]
        Min = 3,
    }
}
