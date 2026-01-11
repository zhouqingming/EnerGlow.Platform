using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 自定义报表类型（0：月表 1：日表 2：设备表）
    /// </summary>
    public enum CustomReportType
    {

        /// <summary>
        /// 月表
        /// </summary>
        [Description("月表")]
        Month = 0,

        /// <summary>
        /// 日表
        /// </summary>
        [Description("日表")]
        Day = 1,

        /// <summary>
        /// 设备表
        /// </summary>
        [Description("设备表")]
        Equipment = 2

    }
}
