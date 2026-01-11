using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 项目个性化配置类型
    /// </summary>
    public enum ProjectDifferType
    {
        /// <summary>
        /// 电量点标签
        /// </summary>
        [Description("电量点标签")]
        ElecPointTag = 0,

        /// <summary>
        /// 天开始时间点
        /// </summary>
        [Description("天开始时间点")]
        DayStartTime = 1,

        /// <summary>
        /// 接收邮箱
        /// </summary>
        [Description("接收邮箱")]
        AcceptMail = 2,

        /// <summary>
        /// 月度报表样式
        /// </summary>
        [Description("月度报表样式")]
        MonthReportStyle = 3,

        /// <summary>
        /// FTP服务器
        /// </summary>
        [Description("FTP服务器")]
        FtpServer = 4,

        /// <summary>
        /// 温度点标签
        /// </summary>
        [Description("温度点标签")]
        TPointTag = 5,

        /// <summary>
        /// 湿度点标签
        /// </summary>
        [Description("湿度点标签")]
        HPointTag = 6,

        /// <summary>
        /// 看板SEO查询天数
        /// </summary>
        [Description("看板SEO查询天数")]
        BoardSeoDayNum = 7,

        /// <summary>
        /// 标签段分隔符
        /// </summary>
        [Description("标签段分隔符")]
        TagSeparator = 8,

        /// <summary>
        /// 数据采集延时
        /// </summary>
        [Description("数据采集延时")]
        DataDelay = 9,

        /// <summary>
        /// 月度抄表同步数据【天】开始时间
        /// </summary>
        [Description("月度抄表同步数据【天】开始时间")]
        MonthReportSyncStartTime = 10,

        /// <summary>
        /// 功率因素测点标签
        /// </summary>
        [Description("功率因数测点标签")]
        PowerFactorTag = 11,

        /// <summary>
        /// 有功功率测点标签
        /// </summary>
        [Description("有功功率测点标签")]
        ActivePowerTag = 12,

        /// <summary>
        /// 无功功率测点标签
        /// </summary>
        [Description("无功功率测点标签")]
        ReactivePowerTag = 13,

        /// <summary>
        /// A相电流测点标签
        /// </summary>
        [Description("A相电流测点标签")]
        IaTag = 14,

        /// <summary>
        /// B相电流测点标签
        /// </summary>
        [Description("B相电流测点标签")]
        IbTag = 15,

        /// <summary>
        /// C相电流测点标签
        /// </summary>
        [Description("C相电流测点标签")]
        IcTag = 16,

        /// <summary>
        /// 功率因素达标值
        /// </summary>
        [Description("功率因数达标值")]
        PowerFactorStandard = 17,

        /// <summary>
        /// 电费单价
        /// </summary>
        [Description("电费单价")]
        ElecPrice = 18,

        /// <summary>
        /// 推迟的测试天数
        /// </summary>
        [Description("推迟的测试天数")]
        DelayDayNum = 19,

        /// <summary>
        /// 是否有变压器
        /// </summary>
        [Description("是否有变压器")]
        IsHasTransformer = 20,

        /// <summary>
        /// 峰段时间
        /// </summary>
        [Description("峰段时间")]
        PeakTimeScope = 21,

        /// <summary>
        /// 平段时间
        /// </summary>
        [Description("平段时间")]
        FlatTimeScope = 22,

        /// <summary>
        /// 谷段时间
        /// </summary>
        [Description("谷段时间")]
        ValleyTimeScope = 23,

        /// <summary>
        /// KPI 自动计划值系数
        /// </summary>
        [Description("KPI自动计划值系数")]
        KPIPlan = 24,

        /// <summary>
        /// 电度最大倍数
        /// </summary>
        [Description("电度最大倍数")]
        MaxMultiple = 25,

        /// <summary>
        /// 峰段电费单价
        /// </summary>
        [Description("峰段电费单价")]
        PeakElecPrice = 26,

        /// <summary>
        /// 平段电费单价
        /// </summary>
        [Description("平段电费单价")]
        FlatElecPrice = 27,

        /// <summary>
        /// 谷段电费单价
        /// </summary>
        [Description("谷段电费单价")]
        ValleyElecPrice = 28,

        /// <summary>
        /// 电度同步手动回补时间
        /// </summary>
        [Description("电度同步手动回补时间")]
        SyncManualFixTime = 29,
    }
}
