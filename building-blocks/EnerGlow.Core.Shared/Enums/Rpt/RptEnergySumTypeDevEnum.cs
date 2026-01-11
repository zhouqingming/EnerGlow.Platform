using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
   public enum RptEnergySumTypeDevEnum
    {
        /// <summary>
        /// 日能耗分类分项设备
        /// </summary>
        [Description("日能耗分类分项设备")]
        DayEnergySumItemDev =1,
        /// <summary>
        /// 月能耗分类分项设备
        /// </summary>
        [Description("月能耗分类分项设备")]
        MonthEnergySumItemDev = 2,
    }
}
