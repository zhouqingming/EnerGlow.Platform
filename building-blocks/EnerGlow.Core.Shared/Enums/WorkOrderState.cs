using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 工单状态(0:正常 1:废弃)
    /// </summary>
    public enum WorkOrderState
    {

        /// <summary>
        /// 正常
        /// </summary>
        [Description("正常")]
        Normal = 0,

        /// <summary>
        /// 废弃
        /// </summary>
        [Description("废弃")]
        Abandon = 1,

    }
}
