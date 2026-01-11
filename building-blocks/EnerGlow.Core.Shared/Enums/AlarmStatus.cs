using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 告警状态（0: 恢复  1: 告警）
    /// </summary>
    public enum AlarmStatus
    {

        /// <summary>
        /// 恢复正常
        /// </summary>
        [Description("恢复正常")]
        Normal = 0,

        /// <summary>
        /// 报警
        /// </summary>
        [Description("报警")]
        Alarm = 1

    }
}
