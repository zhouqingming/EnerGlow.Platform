using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 空调机房看板模块类型
    /// 1:基本信息 2:能耗统计 3:实时监测 4:运行参数 5:即时能效 6:本日能效 7:本月能效 8:热平衡标尺 
    /// 9:每月能效 10:每月能效等级 11:节能效果 12:每月室外温度 13:能效监测 14:设备功耗占比
    /// </summary>
    public enum VrvAreaBoardModuleType
    {

        /// <summary>
        /// 基本信息
        /// </summary>
        [Description("基本信息")]
        BasicInfo = 1,

        /// <summary>
        /// 能耗统计
        /// </summary>
        [Description("能耗统计")]
        EnergyStatistics = 2,

        /// <summary>
        /// 实时监测
        /// </summary>
        [Description("实时监测")]
        RealMonitor = 3,

        /// <summary>
        /// 运行参数
        /// </summary>
        [Description("运行参数")]
        RunParam = 4,

        /// <summary>
        /// 即时能效
        /// </summary>
        [Description("即时能效")]
        CopRankPoint = 5,

        /// <summary>
        /// 本日能效
        /// </summary>
        [Description("本日能效")]
        CopRankToday = 6,

        /// <summary>
        /// 本月能效
        /// </summary>
        [Description("本月能效")]
        CopRankThisMonth = 7,

        /// <summary>
        /// 热平衡标尺
        /// </summary>
        [Description("热平衡标尺")]
        HeatBalance = 8,

        /// <summary>
        /// 每月能效
        /// </summary>
        [Description("每月能效")]
        MonthCop = 9,

        /// <summary>
        /// 每月能效等级
        /// </summary>
        [Description("每月能效等级")]
        MonthCopRank = 10,

        /// <summary>
        /// 系统节能效果
        /// </summary>
        [Description("系统节能效果")]
        SystEnergyEffect = 11,

        /// <summary>
        /// 每月室外温度
        /// </summary>
        [Description("每月室外温度")]
        MonthOutdoorT = 12,

        /// <summary>
        /// 能效监测
        /// </summary>
        [Description("能效监测")]
        DayCopSum = 13,

        /// <summary>
        /// 设备节能效果
        /// </summary>
        [Description("能效监测")]
        DevEnergyEffect = 14

    }
}
