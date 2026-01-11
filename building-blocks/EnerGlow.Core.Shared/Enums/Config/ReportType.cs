using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 报表类型(0：自定义报表  1：月进线报表)
    /// </summary>
    public enum ReportType
    {
        /// <summary>
        /// 自定义报表
        /// </summary>
        [Description("自定义报表")]
        Custom = 0,

        /// <summary>
        /// 月进线报表
        /// </summary>
        [Description("月进线报表")]
        MonthInLine = 1,

        /// <summary>
        /// 广丰电能月报
        /// </summary>
        [Description("广丰电能月报")]
        ElectricityMonthly = 2,

        /// <summary>
        /// 广丰后台数据、压缩空气月报、天然气月报
        /// </summary>
        [Description("广丰后台数据、压缩空气月报、天然气月报")]
        EnergyMonthly = 3,

        /// <summary>
        /// 广丰空气比流值月报表
        /// </summary>
        [Description("广丰空气比流值月报表")]
        FlowValueOfAirMonthly = 4,

        /// <summary>
        /// 广丰自来水月报表
        /// </summary>
        [Description("广丰自来水月报表")]
        EnergyStatisticsMonthly = 5,

        /// <summary>
        /// 广丰排水量月报表
        /// </summary>
        [Description("广丰排水量月报表")]
        EnergyRatioStatisticsMonthly = 6,

        /// <summary>
        /// 广丰区域测点瞬时数据报表
        /// </summary>
        [Description("广丰区域测点瞬时数据报表")]
        MeasuringPointDataMonthly = 7,

        /// <summary>
        /// 广丰能耗流图数据报表
        /// </summary>
        [Description("广丰能耗流图数据报表")]
        EnergyConsuModel = 8,

        /// <summary>
        /// 广丰生产部门产线报表
        /// </summary>
        [Description("广丰生产部门产线报表")]
        ProductionLineReport = 9,

        /// <summary>
        /// 配电房能耗报表
        /// </summary>
        [Description("配电房能耗报表")]
        PdfECMReport = 10,

        /// <summary>
        /// 配电房分类分项报表
        /// </summary>
        [Description("配电房分类分项报表")]
        PdfFLFXReport = 11,

        /// <summary>
        /// 新版峰平谷尖日报表
        /// </summary>
        [Description("新版峰平谷日报表")]
        NewVersionOfPeakPingGuJianDayReport = 12,

        /// <summary>
        /// 新版本峰平谷尖月度报表
        /// </summary>
        [Description("新版峰平谷月报表")]
        NewVersionOfPeakPingJianGuMonthReport = 13,

        /// <summary>
        /// 新版峰平谷尖页面能耗报表
        /// </summary>
        [Description("新版峰平谷尖页面能耗报表")]
        NewVersionOfPeakPingJianGuOtherEnergyReport = 14,

        /// <summary>
        /// 自定义报表中所有设备某一测点的数据报表
        /// </summary>
        [Description("自定义报表中所有设备某一测点的数据报表")]
        SpecificPointDataOnAllCustomDevices = 15,
    }
}
