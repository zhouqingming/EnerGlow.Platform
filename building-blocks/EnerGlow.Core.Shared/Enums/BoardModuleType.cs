using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 看板模块类型
    /// (0: 能耗汇总  1:能耗对标  2:昨天能耗结构  3:昨天能耗峰平谷  4:本日每小时能耗  5:本日每小时电流  6:本日每小时电压  7:本日每小时功率因数)
    /// </summary>
    public enum BoardModuleType
    {
        /// <summary>
        /// 能耗汇总
        /// </summary>
        [Description("能耗汇总")]
        EnergySummary = 0,

        /// <summary>
        /// 能耗对标
        /// </summary>
        [Description("能耗对标")]
        EnergyComparison = 1,

        /// <summary>
        /// 昨天能耗结构
        /// </summary>
        [Description("昨天能耗结构")]
        YesterdayEnergyCompare = 2,

        /// <summary>
        /// 昨天每小时能耗峰平谷
        /// </summary>
        [Description("昨天能耗峰平谷")]
        YesterdayScopeHourEp = 3,

        /// <summary>
        /// 本日每小时能耗
        /// </summary>
        [Description("本日每小时能耗")]
        TodayHourEp = 4,

        /// <summary>
        /// 本日每小时电流
        /// </summary>
        [Description("本日每小时电流")]
        TodayHourI = 5,

        /// <summary>
        /// 本日每小时电压
        /// </summary>
        [Description("本日每小时电压")]
        TodayHourU = 6,

        /// <summary>
        /// 本日每小时功率因数
        /// </summary>
        [Description("本日每小时功率因数")]
        TodayHourPF = 7,
        /// <summary>
        /// 本月生产单耗
        /// </summary>
        [Description("本月生产单耗")]
        ActualUnitConsumpte = 8,
        /// <summary>
        /// 本月电耗预测
        /// </summary>
        [Description("本月电耗预测")]
        MonthKwhForecast = 9,
        /// <summary>
        /// 本日分时段能耗占比
        /// </summary>
        [Description("本日分时段能耗占比")]
        TimeEnergyRatio = 10,
        /// <summary>
        /// 本月电耗同比
        /// </summary>
        [Description("本月电耗同比")]
        MonthKwhCompare = 11,
        /// <summary>
        /// 本月电耗环比
        /// </summary>
        [Description("本月电耗环比")]
        MonthKwhChain = 12,
        /// <summary>
        /// 能耗设备排比
        /// </summary>
        [Description("能耗设备排比")]
        StatisticsDevPar = 13,
        /// <summary>
        /// 分区能耗占比
        /// </summary>
        [Description("分区能耗占比")]
        DevKwhRatio = 14,
        /// <summary>
        /// 分区能耗同比
        /// </summary>
        [Description("分区能耗同比")]
        DevKwhCompare = 15,
        /// <summary>
        /// 分区能耗环比
        /// </summary>
        [Description("分区能耗环比")]
        DevKwhChain = 16,
        /// <summary>
        /// 生产耗能/非生产耗能
        /// </summary>
        [Description("生产耗能/非生产耗能")]
        DayProductiveKwh = 17,
        /// <summary>
        /// 用电占比
        /// </summary>
        [Description("用电占比")]
        KwhRatio = 18,

        /// <summary>
        /// 电房能耗
        /// </summary>
        [Description("电房能耗")]
        ElecRoomEnergy = 19,
        /// <summary>
        /// 能耗设备排比（设备）
        /// </summary>
        [Description("能耗设备排比（设备）")]
        StatisticsDev = 20,
        /// <summary>
        /// 日分类分项
        /// </summary>
        [Description("日分类分项")]
        DayEneProportion = 21,

        /// <summary>
        /// 本月同环比的天电度消耗量
        /// </summary>
        [Description("本月同比环比的天电度消耗量")]
        MonthDay = 22,

        /// <summary>
        ///本日每小时能耗峰平谷
        /// </summary>
        [Description("本日每小时能耗峰平谷")]
        TodayElecScopeHour = 23,

        /// <summary>
        /// 本月每天能耗
        /// </summary>
        [Description("本月每天能耗")]
        ThisMonthDay = 24,

        /// <summary>
        /// 本年每月能耗
        /// </summary>
        [Description("本年每月能耗")]
        ThisYearMonth = 25,

        /// <summary>
        /// 昨天能源种类能耗结构
        /// </summary>
        [Description("昨天能源种类能耗结构")]
        YesterdayKindStructure = 26,

        /// <summary>
        /// 上月能耗对标
        /// </summary>
        [Description("上月能耗对标")]
        LastMonthComparison = 27,

        /// <summary>
        /// 昨日每小时能耗
        /// </summary>
        [Description("昨日每小时能耗")]
        YesterdayHour = 28,

        /// <summary>
        /// 车间上月能耗对标
        /// </summary>
        [Description("车间上月能耗对标")]
        LastMonthWorkshopComparison = 29,

        /// <summary>
        /// 获取所有能源种类的能耗汇总
        /// </summary>
        [Description("获取所有能源种类的能耗汇总")]
        EnergySummaryAll = 30,

        /// <summary>
        /// 获取所有能源种类的年月日能耗和同比或者环比
        /// </summary>
        [Description("获取所有能源种类的年月日能耗和同比或者环比")]
        EnergyYmdDataCopare = 31,

        /// <summary>
        /// 获取所有能源种类的年月日能耗和同比或者环比
        /// </summary>
        [Description("获取所有能源种类单耗的年月日单耗和同比或者环比")]
        UnitEnergyYmdDataCopare = 32,

        /// <summary>
        /// 获取子级能耗占比
        /// </summary>
        [Description("获取子级能耗占比")]
        EnerygyProportion = 33,

        /// <summary>
        /// 实际能耗和计划能耗，单耗的对比
        /// </summary>
        [Description("实际能耗和计划能耗，单耗的对比")]
        EnergyContrast = 34,

        /// <summary>
        /// 获取当前区域子级所有数据年月日能耗和同比或者环比
        /// </summary>
        [Description("获取当前区域子级所有数据年月日能耗和同比或者环比")]
        EnergyYmdDataCopareSum = 35,

        /// <summary>
        /// 指定时间类型能源种类能耗结构 
        /// </summary>
        [Description("指定时间类型能源种类能耗结构")]
        SpecifiedDateTimeTypeEnergyKindStructure = 36,

        /// <summary>
        /// 设备天能耗数据 
        /// </summary>
        [Description("设备天能耗数据")]
        DevDayEnergy =37,

        /// <summary>
        /// 设备月能耗数据 
        /// </summary>
        [Description("设备月能耗数据")]
        DevMonthEnergy = 38,

        /// <summary>
        /// 设备年能耗数据 
        /// </summary>
        [Description("设备年能耗数据")]
        DevYearEnergy = 39,

        /// <summary>
        /// 天能效趋势 
        /// </summary>
        [Description("天能效趋势")]
        EnergyDayTrend =40,

        /// <summary>
        /// 月能效趋势 
        /// </summary>
        [Description("月能效趋势")]
        EnergyMonthTrend = 41,

        /// <summary>
        /// 年能效趋势 
        /// </summary>
        [Description("年能效趋势")]
        EnergyYearTrend = 42,

        /// <summary>
        /// 日能耗和单设备实时数据 
        /// </summary>
        [Description("日能耗和单设备实时数据")]
        WaterEnergyDayList = 43,

        /// <summary>
        /// 月能耗和单设备实时数据 
        /// </summary>
        [Description("月能耗和单设备实时数据")]
        WaterEnergyMonthList = 44,

        /// <summary>
        /// 年能耗和单设备实时数据 
        /// </summary>
        [Description("年能耗和单设备实时数据")]
        WaterEnergyYearList = 45,

        /// <summary>
        /// 空调机房能效实时
        /// </summary>
        [Description("空调机房能效实时")]
        ComputerRoomEffectRealTime = 46,

        /// <summary>
        /// 空调机房能效月 
        /// </summary>
        [Description("空调机房能效月")]
        ComputerRoomEffectMonth =47,

        /// <summary>
        /// 空调机房能效年 
        /// </summary>
        [Description("空调机房能效年")]
        ComputerRoomEffectYear =48,

        /// <summary>
        /// 制冷量 
        /// </summary>
        [Description("制冷量")]
        CoolingEnergySummary =49,

        /// <summary>
        /// 空调机房能效年 
        /// </summary>
        [Description("空调机房能效日")]
        ComputerRoomEffectDay = 50,

        /// <summary>
        /// 月分类分项 
        /// </summary>
        [Description("月分类分项")]
        MonthEneProportion =51,

        /// <summary>
        /// 年分类分项 
        /// </summary>
        [Description("年分类分项")]
        YearEneProportion = 52,

        /// <summary>
        /// 能耗汇总和同环比数据 
        /// </summary>
        [Description("能耗汇总和同环比数据")]
        EnergySummaryAndCompare =53,

        /// <summary>
        /// 上月每天能耗 
        /// </summary>
        [Description("上月每天能耗")]
        LastMonthDay =54,

        /// <summary>
        /// 安全运行天数 
        /// </summary>
        [Description("安全运行天数")]
        SafeDays =55,

        /// <summary>
        /// 区域所有设备的实时数据 
        /// </summary>
        [Description("区域所有设备的实时数据")]
        AreaDevData =56,

        /// <summary>
        /// 峰平谷汇总数据
        /// </summary>
        [Description("峰平谷汇总数据")]
        ScopeDayData = 57,

        /// <summary>
        /// 能耗模型配置中二级区域实时功率数据
        /// </summary>
        [Description("能耗模型配置中二级区域实时功率数据")]
        RealTimeKwData = 58,

        /// <summary>
        /// 昨日每小时能耗
        /// </summary>
        [Description("昨日每小时能耗")]
        YesterdatHourEp = 59,

        /// <summary>
        /// 年三级分类分项 
        /// </summary>
        [Description("三级分类分项")]
        ThreeLevelEneProportion = 60,

        /// <summary>
        /// 本年每个月各能源单耗同比和环比数据 
        /// </summary>
        [Description("本年每个月各能源单耗同比和环比数据")]
        SingleEnergySummaryCompare = 61,

        /// <summary>
        /// 能耗列表和同环比数据,最大最小值 
        /// </summary>
        [Description("能耗列表和同环比数据,最大最小值")]
        EnergyListAndCompare = 62,

        /// <summary>
        /// 用能指标(本月)
        /// </summary>
        [Description("用能指标(本月)")]
        EnergyConsumption=63,

        /// <summary>
        /// 分类分项能耗占比图
        /// </summary>
        [Description("分类分项能耗占比图")]
        EnergyConsuModelData =64,

        /// <summary>
        /// 车站指标
        /// </summary>
        [Description("车站指标")]
        EnergyTarget =65,

        /// <summary>
        /// 去年每月能耗
        /// </summary>
        [Description("去年每月能耗")]
        LastYearMonth = 66,

        /// <summary>
        /// 本月分类分项占比
        /// </summary>
        [Description("本月分类分项占比")]
        ThisMonthEneReportRatio = 67,

        /// <summary>
        /// 本月分类分项占比
        /// </summary>
        [Description("上月分类分项占比")]
        LastMonthEneReportRatio = 68,

        /// <summary>
        /// 区域设备实时数据
        /// </summary>
        [Description("区域设备实时数据")]
        AreaDeviceRealTimeData = 69,

        /// <summary>
        /// 本月设备能耗排行
        /// </summary>
        [Description("本月设备能耗排行")]
        MonthDevEnergyConsumptionRanking = 70,

        /// <summary>
        /// 年吨水电趋势
        /// </summary>
        [Description("年吨水电趋势")]
        YearTonHydropowerTrend = 71,

        /// <summary>
        /// 本月能耗模型标签的能耗汇总值
        /// </summary>
        [Description("本月能耗模型标签的能耗汇总值")]
        ModelEnergyConsumptionModelTagEnergy = 72,

        /// <summary>
        /// 区域通讯状态
        /// </summary>
        [Description("区域通讯状态")]
        AreaCommStatus = 73,

        /// <summary>
        /// SOE报警类型报警Soe事件次数统计
        /// </summary>
        [Description("SOE报警类型报警Soe事件次数统计")]
        SoeAlarmTypeSoeCountStatistics = 74,

        /// <summary>
        /// 设备报警Soe事件次数统计
        /// </summary>
        [Description("设备报警Soe事件次数统计")]
        DeviceAlarmSoeCountStatistics = 75,

        /// <summary>
        /// 设备报警Soe事件次数统计
        /// </summary>
        [Description("Soe报警明细（根据soe报警类型分组）")]
        SoeAbnormalDetailInfoGroupAlarmType = 76,

        /// <summary>
        /// 本日分类分项占比
        /// </summary>
        [Description("本日分类分项占比")]
        ThisDayEneReportRatio = 77,

        /// <summary>
        /// 上月吨水电耗分类分项占比
        /// </summary>
        [Description("上月吨水电耗分类分项占比")]
        LastMonthTonHydropowerRatio = 78,

        /// <summary>
        /// 月吨水电趋势
        /// </summary>
        [Description("月吨水电趋势")]
        MonthTonHydropowerTrend = 79,

        /// <summary>
        /// 日吨水电趋势
        /// </summary>
        [Description("日吨水电趋势")]
        DayTonHydropowerTrend = 80,

        /// <summary>
        /// 昨日分类分项占比
        /// </summary>
        [Description("昨日分类分项占比")]
        LastDayEneReportRatio = 81,

        /// <summary>
        /// 本年设备运行时长
        /// </summary>
        [Description("本年设备运行时长")]
        ThisYearDevRunningTimeData = 82,

        /// <summary>
        /// 本月设备运行时长
        /// </summary>
        [Description("本月设备运行时长")]
        ThisMonthDevRunningTimeData = 83,

        /// <summary>
        /// 本日设备运行时长
        /// </summary>
        [Description("本日设备运行时长")]
        ThisDayDevRunningTimeData = 84,

        /// <summary>
        /// 本年分类分项占比
        /// </summary>
        [Description("本年分类分项占比")]
        ThisYearEneReportRatio = 85,

        /// <summary>
        /// 上年分类分项占比
        /// </summary>
        [Description("上年分类分项占比")]
        LastYearEneReportRatio = 86,

        /// <summary>
        /// 能耗汇总同环比
        /// </summary>
        [Description("能耗汇总同环比")]
        EnergySummarySameRatio =87,

        /// <summary>
        /// 根据模型和能源种类分类能耗天数据
        /// </summary>
        [Description("根据模型和能源种类分类能耗天数据")]
        DayOfEnergyGroupModelAndDevType = 88,

        /// <summary>
        /// 根据模型和能源种类分类能耗月数据
        /// </summary>
        [Description("根据模型和能源种类分类能耗月数据")]
        MonthOfEnergyGroupModelAndDevType = 89,

        /// <summary>
        /// 根据模型和能源种类分类能耗年数据
        /// </summary>
        [Description("根据模型和能源种类分类能耗年数据")]
        YearOfEnergyGroupModelAndDevType = 90,

        /// <summary>
        /// 新分类分项
        /// </summary>
        [Description("新分类分项")]
        DayEneProportionN = 91,

        /// <summary>
        /// 指定数据
        /// </summary>
        [Description("指定数据")]
        AssignData = 92,

        /// <summary>
        /// 产线单耗数据
        /// </summary>
        [Description("产线单耗数据")]
        ProductionlineUnit =93,

        /// <summary>
        /// 能耗设备排比（重点设备）
        /// </summary>
        [Description("能耗设备排比（重点设备）")]
        StatisticsStressDev = 94,
    }
}
