using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 配置类型 2年报表 - 分类分项  4月报表 - 分类分项 6日报表 - 分类分项 7日报表 - 分类分项(末端）
    /// </summary>
    public enum RptEneModuleTypesEnum
    {
        /// <summary>
        /// 年报表-分类分项
        /// </summary>
        [Description("年报表-分类分项")]
        EneYearReport =1,
        /// <summary>
        /// 年报表-分类分项导出
        /// </summary>
        [Description("年报表-分类分项导出")]
        EneYearReportExport = 2,
        /// <summary>
        /// 月报表 - 分类分项
        /// </summary>
        [Description("月报表-分类分项")]
        EneMonthReport =3,
        /// <summary>
        /// 月报表 - 分类分项导出
        /// </summary>
        [Description("月报表-分类分项导出")]
        EneMonthReportExport = 4, 
        /// <summary>
        /// 日报表-分类分项
        /// </summary>
        [Description("日报表-分类分项")]
        EneDayReport = 5,
        /// <summary>
        /// 日报表-分类分项导出
        /// </summary>
        [Description("日报表-分类分项导出")]
        EneDayReportExport = 6,
        /// <summary>
        /// 日报表-分类分项导出(末端）
        /// </summary>
        [Description("日报表-分类分项(末端）")]
        EneDayReportEnd = 7,
        /// <summary>
        /// 日报表-分类分项导出(末端）
        /// </summary>
        [Description("日报表-分类分项导出(末端）")]
        EneDayReportEndExport = 8,
        /// <summary>
        /// 季报表-分类分项
        /// </summary>
        [Description("季报表-分类分项")]
        EneQuarterReport =9,
        /// <summary>
        /// 季报表-分类分项导出
        /// </summary>
        [Description("季报表-分类分项导出")]
        EneQuarterReportExport =10,

    }
}
