using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 监测类型(1：限值监测 2：报警监测 3：公式限值监测 4：统计值监测)
    /// </summary>
    public enum MonitorType
    {

        /// <summary>
        /// 限值监测
        /// </summary>
        [Description("限值监测")]
        LimitValue = 1,

        /// <summary>
        /// 报警监测
        /// </summary>
        [Description("报警监测")]
        Alarm = 2,

        /// <summary>
        /// 公式限值监测
        /// </summary>
        [Description("公式限值监测")]
        FormulaValue = 3,

        /// <summary>
        /// 统计值监测
        /// </summary>
        [Description("统计值监测")]
        StatisticsValue = 4

    }
}
