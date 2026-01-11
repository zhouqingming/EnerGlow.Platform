using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 日期时间类型
    /// </summary>
    public enum DateTimeType
    {
        /// <summary>
        /// 年
        /// </summary>
        [Description("年")]
        Year = 0,

        /// <summary>
        /// 季度
        /// </summary>
        [Description("季度")]
        Quarter = 1,

        /// <summary>
        /// 月
        /// </summary>
        [Description("月")]
        Month = 2,

        /// <summary>
        /// 周
        /// </summary>
        [Description("周")]
        Week = 3,

        /// <summary>
        /// 日
        /// </summary>
        [Description("日")]
        Day = 4,

        /// <summary>
        /// 小时
        /// </summary>
        [Description("小时")]
        Hour = 5,

        /// <summary>
        /// 自由时间
        /// </summary>
        [Description("自由时间")]
        Free = 6,

        /// <summary>
        /// 瞬时
        /// </summary>
        [Description("瞬时")]
        RealTime =7,

        /// <summary>
        /// 上个月
        /// </summary>
        [Description("上个月")]
        LastMonth = 8,
    }
}
