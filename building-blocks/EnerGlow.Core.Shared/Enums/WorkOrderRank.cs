using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 工单级别(0：普通  1：紧急 2：特急)
    /// </summary>
    public enum WorkOrderRank
    {

        /// <summary>
        /// 普通
        /// </summary>
        [Description("普通")]
        General = 0,

        /// <summary>
        /// 紧急
        /// </summary>
        [Description("紧急")]
        Urgency = 1,

        /// <summary>
        /// 特急
        /// </summary>
        [Description("特急")]
        VeryUrgent = 2
    }
}
