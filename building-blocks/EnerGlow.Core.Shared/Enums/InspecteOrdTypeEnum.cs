using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 巡检单类型 1指派2系统推送
    /// </summary>
    public enum InspecteOrdTypeEnum
    {
        /// <summary>
        /// 1指派
        /// </summary>
        [Description("指派")]
        Assign = 1,
        /// <summary>
        /// 2系统推送
        /// </summary>
        [Description("系统推送")]
        SystemPush = 2
    }
}
