using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared.Rpt
{

    /// <summary>
    /// 年月日报表-分类分项导出
    /// </summary>
    public enum RptEneExportModuleTypesEnum
    {
        /// <summary>
        /// 年报表-分类分项导出
        /// </summary>
        [Description("年报表-分类分项导出")]
        EneYearReportExport = 1,
        /// <summary>
        /// 月报表 - 分类分项导出
        /// </summary>
        [Description("月报表-分类分项导出")]
        EneMonthReportExport = 2,
        /// <summary>
        /// 日报表-分类分项导出
        /// </summary>
        [Description("日报表-分类分项导出")]
        EneDayReportExport = 3,
        /// <summary>
        /// 日报表-分类分项导出(末端）
        /// </summary>
        [Description("日报表-分类分项导出(末端）")]
        EneDayReportEndExport =4,
    }
}
