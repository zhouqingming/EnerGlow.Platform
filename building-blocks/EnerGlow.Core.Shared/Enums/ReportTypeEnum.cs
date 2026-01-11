using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 报表类型枚举
    /// </summary>
    public enum ReportTypeEnum
    {
        /// <summary>
        /// 抄表
        /// </summary>
        [Description("抄表")]
        MeterReading =0,

        /// <summary>
        /// 按设备汇总报表
        /// </summary>
        [Description("按设备汇总报表")]
        SummaryReport =1,

        /// <summary>
        /// 所有设备汇总
        /// </summary>
        [Description("所有设备汇总")]
        AllSummaryReport =2,

        /// <summary>
        /// 自定义报表
        /// </summary>
        [Description("自定义报表")]
        CustomReport =3
    }
}
