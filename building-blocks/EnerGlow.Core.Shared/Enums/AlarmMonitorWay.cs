using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 报警监测模式(0:持续 1:定时)
    /// </summary>
    public enum AlarmMonitorWay
    {

        /// <summary>
        /// 持续
        /// </summary>
        [Description("持续")]
        AllTime = 0,

        /// <summary>
        /// 定时
        /// </summary>
        [Description("定时")]
        OnTime = 1
    }
}
