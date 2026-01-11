using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 数据录入
    /// </summary>
   public  enum DataEntryEnum
    {
        /// <summary>
        /// 年数据 
        /// </summary>
        [Description("年数据")]
        YearData = 1,
        /// <summary>
        /// 月数据 
        /// </summary>
        [Description("月数据")]
        MonthData = 2,
        /// <summary>
        /// 天数据 
        /// </summary>
        [Description("年数据")]
        DayData = 3,
        /// <summary>
        /// 时数据 
        /// </summary>
        [Description("时数据")]
        HourData = 4,
    }
}
