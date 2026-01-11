using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 分区分户
    /// </summary>
    public enum RptDivModuleTypesEnum
    {
        /// <summary>
        /// 日报表 - 分区分户
        /// </summary>
        [Description("日报表-分区分户")]
        PartDayReport = 1,
        /// <summary>
        /// 日报表 - 分区分户导出
        /// </summary>
        [Description("日报表-分区分户导出")]
        PartDayReportExport = 2,
        /// <summary>
        /// 年报表-分区分户
        /// </summary>
        [Description("年报表-分区分户")]
        PartYearReport = 3,
        /// <summary>
        /// 年报表-分区分户导出
        /// </summary>
        [Description("年报表-分区分户导出")]
        PartYearReportExport = 4,  
        /// <summary>
        /// 月报表 - 分区分户
        /// </summary>
        [Description("月报表-分区分户")]
        PartMonthReport = 5,
        /// <summary>
        /// 月报表-分区分户导出
        /// </summary>
        [Description("月报表-分区分户导出")]
        PartMonthReportExport = 6,
    }
}
