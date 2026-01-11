using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 告警类型（1：参数告警 2：指标告警）
    /// </summary>
    public enum AlarmItemType
    {

        /// <summary>
        /// 参数告警
        /// </summary>
        [Description("参数告警")]
        Argument = 1,

        /// <summary>
        /// 指标告警
        /// </summary>
        [Description("指标告警")]
        Index = 2,

    }
}
