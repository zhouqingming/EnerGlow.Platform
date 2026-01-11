using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 工单时间单位(0:分 1:时 2:日 3:月)
    /// </summary>
    public enum WorkOrderTimeUnit
    {

        /// <summary>
        /// 分
        /// </summary>
        [Description("分")]
        Minute = 0,

        /// <summary>
        /// 时
        /// </summary>
        [Description("时")]
        Hour = 1,

        /// <summary>
        /// 日
        /// </summary>
        [Description("日")]
        Day = 2,

        /// <summary>
        /// 月
        /// </summary>
        [Description("月")]
        Month = 3
    }
}
