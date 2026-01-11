using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 时间类型 1年份 2月份 3小时
    /// </summary>
    public enum RptTimeTypeEnum
    {
       /// <summary>
       /// 年份
       /// </summary>
        [Description("年份")]
        RptYear = 1,
        /// <summary>
        /// 月份
        /// </summary>
        [Description("月份")]
        RptMonth = 2,
        /// <summary>
        /// 小时
        /// </summary>
        [Description("小时")]
        RptDay = 3,
    }
}
