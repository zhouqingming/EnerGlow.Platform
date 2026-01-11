using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 能耗分类分项
    /// </summary>
   public enum RptEnergySumTypeEnum
    {

        /// <summary>
        /// 日能耗分类分项
        /// </summary>
        [Description("日能耗分类分项")]
        DayEnergySumItem = 1,
        /// <summary>
        /// 月能耗分类分项
        /// </summary>
        [Description("月能耗分类分项")]
        MonthEnergySumItem =2,
        

    }
}
