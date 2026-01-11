using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 巡检单状态1 未完成 2已完成
    /// </summary>
    public enum InspecteStateEnum
    {
        /// <summary>
        /// 1未完成
        /// </summary>
        [Description("未完成")]
        NotComplete = 1,
        /// <summary>
        /// 2已完成
        /// </summary>
        [Description("已完成")]
        AlreadyComplete = 2
    }
}
