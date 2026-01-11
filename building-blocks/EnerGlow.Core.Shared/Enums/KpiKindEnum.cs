using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 能耗KPI 获取方式枚举
    /// </summary>
    public enum KpiKindEnum
    {
        /// <summary>
        /// 总能耗
        /// </summary>
        [Description("总能耗")]
        总能耗 = 1,
        /// <summary>
        /// 部门能耗
        /// </summary>
        [Description("部门能耗")]
        部门能耗 = 2,

        /// <summary>
        /// 电房能耗
        /// </summary>
        [Description("电房能耗")]
        电房能耗 = 3,

        /// <summary>
        /// 单耗能耗
        /// </summary>
        [Description("单耗能耗")]
        单耗能耗 = 4,

        /// <summary>
        /// 班组能耗
        /// </summary>
        [Description("班组能耗")]
        班组能耗 = 5,

        /// <summary>
        /// 车间能耗
        /// </summary>
        [Description("车间能耗")]
        车间能耗 = 6,

        /// <summary>
        /// 区域能耗
        /// </summary>
        [Description("区域能耗")]
        区域能耗 = 7,

        /// <summary>
        /// 设备能耗
        /// </summary>
        [Description("设备能耗")]
        设备能耗 = 8,

        /// <summary>
        /// 稼动能耗
        /// </summary>
        [Description("稼动能耗")]
        稼动能耗 = 9,

        /// <summary>
        /// 非稼动能耗
        /// </summary>
        [Description("非稼动能耗")]
        非稼动能耗 = 10,

        /// <summary>
        /// 人流量
        /// </summary>
        [Description("人流量")]
        人流量 =11
    }
}
