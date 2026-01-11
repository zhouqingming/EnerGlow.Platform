using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 工单类型（1：巡检 2：保养 3：应急 4：报警）
    /// </summary>
    public enum WorkOrderType
    {

        /// <summary>
        /// 巡检
        /// </summary>
        [Description("巡检")]
        Patrol = 1,

        /// <summary>
        /// 保养
        /// </summary>
        [Description("保养")]
        Upkeep = 2,

        /// <summary>
        /// 应急
        /// </summary>
        [Description("应急")]
        Emergent = 3,

        /// <summary>
        /// 报警
        /// </summary>
        [Description("报警")]
        Alarm = 4,

        /// <summary>
        /// 视频
        /// </summary>
        [Description("视频")]
        Video = 5

    }
}
